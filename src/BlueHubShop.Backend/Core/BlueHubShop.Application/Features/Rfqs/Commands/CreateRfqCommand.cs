using MediatR;
using BlueHubShop.Application.Common.Interfaces;
using BlueHubShop.Application.DTOs;
using BlueHubShop.Domain.Entities;

namespace BlueHubShop.Application.Features.Rfqs.Commands;

public record CreateRfqCommand(CreateRfqRequestDto Request) : IRequest<int>;

public class CreateRfqCommandHandler : IRequestHandler<CreateRfqCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateRfqCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateRfqCommand request, CancellationToken cancellationToken)
    {
        var dto = request.Request;

        var rfq = new ReqRequestSupplierProduct
        {
            StockId = dto.ProductId,
            Qty = dto.Quantity,
            DeliveryPlace = dto.PortOfDelivery,
            DeliveryTime = dto.EtaDate?.ToString("yyyy-MM-dd"),
            VesselRemark = $"Vessel: {dto.VesselName}, IMO: {dto.ImoNumber}. Notes: {dto.Notes}. Contact: {dto.ContactEmail} / {dto.ContactPhone}",
            Status = "Pending",
            CreatedDate = DateTime.UtcNow,
            CreatedBy = dto.ContactEmail ?? "Web-RFQ-Customer"
        };

        _context.ReqRequestSupplierProducts.Add(rfq);
        await _context.SaveChangesAsync(cancellationToken);

        return rfq.Id;
    }
}
