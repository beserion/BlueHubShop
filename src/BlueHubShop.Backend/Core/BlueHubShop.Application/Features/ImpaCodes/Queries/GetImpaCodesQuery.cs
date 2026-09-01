using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using BlueHubShop.Application.Common.Interfaces;
using BlueHubShop.Application.DTOs;

namespace BlueHubShop.Application.Features.ImpaCodes.Queries;

public record GetImpaCodesQuery(string? Search = null) : IRequest<List<ImpaGroupDto>>;

public class GetImpaCodesQueryHandler : IRequestHandler<GetImpaCodesQuery, List<ImpaGroupDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMemoryCache _cache;

    public GetImpaCodesQueryHandler(IApplicationDbContext context, IMemoryCache cache)
    {
        _context = context;
        _cache = cache;
    }

    public async Task<List<ImpaGroupDto>> Handle(GetImpaCodesQuery request, CancellationToken cancellationToken)
    {
        string cacheKey = $"impa_{request.Search}";

        if (_cache.TryGetValue(cacheKey, out List<ImpaGroupDto>? cached) && cached != null)
        {
            return cached;
        }

        var query = _context.GnlProducts
            .AsNoTracking()
            .Where(p => !string.IsNullOrEmpty(p.Impacode) && p.IsDeleted != true);

        if (!string.IsNullOrWhiteSpace(request.Search))
        {
            query = query.Where(p => p.Impacode!.Contains(request.Search));
        }

        // Group by first 2 digits of IMPA code (e.g. "33", "21", "75")
        var rawGroups = await query
            .GroupBy(p => p.Impacode!.Substring(0, 2))
            .Select(g => new
            {
                Code = g.Key,
                Count = g.Count()
            })
            .ToListAsync(cancellationToken);

        var sectionNames = new Dictionary<string, (string Name, string Desc)>
        {
            ["01"] = ("Navigation Equipment & Instruments", "Magnetic compasses, sextants, charts and marine chronometers."),
            ["03"] = ("Deck Machinery & Anchoring", "Windlasses, winches, capstans, mooring fairleads and roller chocks."),
            ["05"] = ("Safety & Life Saving (LSA)", "Lifebuoys, lifejackets, water lights, pilot ladders, survival suits."),
            ["12"] = ("Engine Room Equipment & Systems", "Cooling systems, oil filters, heat exchangers, strainers and gauges."),
            ["13"] = ("Pumps & Pumping Equipment", "Centrifugal, gear, screw, bilge, and ballast pumps."),
            ["15"] = ("Cloth, Linen & Accommodation Goods", "Bed sheets, blankets, mattresses, pillows, towels, galley aprons."),
            ["17"] = ("Tableware & Galley Utensils", "Cooking pots, stainless steel pans, chef knives, plates, cutlery."),
            ["19"] = ("Clothing & Crew Uniforms", "Boiler suits, rainwear, safety boots, parkas."),
            ["21"] = ("Ropes, Hawsers & Mooring Lines", "Polypropylene, nylon, polyester, wire ropes, Dyneema 8/12-strand."),
            ["23"] = ("Rigging Equipment & Deck Hardware", "Shackles, turnbuckles, wire clips, thimbles, cargo hooks, chain blocks."),
            ["25"] = ("Marine Paint & Primers", "Antifouling coatings, epoxy primers, polyurethane deck finishes."),
            ["31"] = ("Safety Protective Gear & PPE", "Hard hats, safety goggles, ear defenders, welder gloves, harness belts."),
            ["33"] = ("Safety Equipment (LSA / FFA / SOLAS)", "SOLAS lifejackets, SCBA sets, EEBD, fire hoses, Storz nozzles, flares."),
            ["35"] = ("Hose & Couplings", "Water, steam, air, oil hoses, Camlock & Storz quick couplings."),
            ["37"] = ("Nautical Equipment & Log Systems", "Radars, echo sounders, barometers, anemometers, radar reflectors."),
            ["45"] = ("Petroleum Products & Marine Lubes", "Cylinder oils, system oils, hydraulic oil ISO VG 46/68, high temp greases."),
            ["55"] = ("Cleaning Material & Hold Chemicals", "Cargo hold cleaner, carbon remover, degreasers, electric motor cleaner."),
            ["59"] = ("Pneumatic & Electrical Power Tools", "Jet chisels, deck scaling machines, pneumatic angle grinders, drills."),
            ["61"] = ("Hand Tools (Spanners, Sockets, Hammers)", "Combination spanners, socket sets, non-sparking copper beryllium tools."),
            ["63"] = ("Cutting Tools & Taps", "HSS drill bits, hand taps, thread dies, hole saws, hacksaw blades."),
            ["65"] = ("Measuring Tools & Gauges", "Vernier calipers, micrometer sets, pressure test gauges, dial indicators."),
            ["67"] = ("Metal Sheets, Bars & Plates", "Stainless steel 316 plates, brass rods, seamless tubes, shim steel."),
            ["69"] = ("Screws, Nuts, Bolts & Washers", "Hex head bolts (DIN 933), nylon lock nuts, spring washers, stud bolts."),
            ["71"] = ("Pipes & Tubes (Steel, Copper, Plastic)", "Schedule 40/80 seamless pipes, copper nickel pipes, PVC pipes."),
            ["73"] = ("Pipe & Tube Fittings & Flanges", "DIN / JIS pipe flanges, elbows, tees, unions, Dresser couplings."),
            ["75"] = ("Valves & Cocks (Marine Type)", "Cast iron/bronze globe valves, butterfly valves, storm valves, cock valves."),
            ["77"] = ("Bearings & Bearing Housings", "Deep groove ball bearings, spherical roller bearings, pillow blocks (SKF/FAG)."),
            ["79"] = ("Electrical Equipment & Switchgear", "Marine contactors, circuit breakers, terminal blocks, test multimeters."),
            ["81"] = ("Lighting & Ex-Proof Fixtures", "Ex-proof fluorescent/LED lights, Suez Canal searchlights, navigation bulbs."),
            ["85"] = ("Welding Equipment & Electrodes", "Inverter welding sets, E6013/E7018 electrodes, TIG torches, cutting nozzles."),
            ["91"] = ("Provisions & Fresh Food Stores", "Fresh meat, poultry, vegetables, dairy, dry canned goods for ship crews."),
            ["93"] = ("Slop Chest & Bonded Stores", "Duty free tobacco, confectionery, beverages, personal care items.")
        };

        var result = rawGroups.Select(g => {
            string name = sectionNames.ContainsKey(g.Code) ? sectionNames[g.Code].Name : $"Section {g.Code} Technical Marine Equipment";
            string desc = sectionNames.ContainsKey(g.Code) ? sectionNames[g.Code].Desc : "Technical maritime supply catalog.";
            return new ImpaGroupDto
            {
                Code = g.Code,
                Name = name,
                Description = desc,
                Count = g.Count,
                SampleCodes = new List<string> { $"{g.Code} 01 01", $"{g.Code} 02 15", $"{g.Code} 04 20" }
            };
        })
        .OrderBy(g => g.Code)
        .ToList();

        _cache.Set(cacheKey, result, TimeSpan.FromMinutes(10));
        return result;
    }
}
