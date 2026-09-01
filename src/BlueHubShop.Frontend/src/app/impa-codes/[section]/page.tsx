"use client";

import React, { useState, use } from "react";
import { Navbar } from "@/components/navbar";
import { Search, BookOpen, ArrowLeft, ExternalLink, ShieldCheck, Tag, Anchor, Filter } from "lucide-react";
import { motion } from "framer-motion";
import Link from "next/link";

interface ImpaDetailItem {
  code: string;
  issaCode: string;
  name: string;
  unit: string;
  material: string;
  description: string;
  activeListingsCount: number;
}

const SAMPLE_IMPA_ITEMS: Record<string, ImpaDetailItem[]> = {
  "33": [
    { code: "33 04 11", issaCode: "33.041.11", name: "Self-Contained Breathing Apparatus (SCBA) 300 Bar Composite Cylinder", unit: "Set", material: "Carbon Composite / Steel", description: "SOLAS/MED approved positive pressure open circuit breathing set with full face mask and warning whistle.", activeListingsCount: 14 },
    { code: "33 04 16", issaCode: "33.041.16", name: "Emergency Escape Breathing Device (EEBD) 15 Min", unit: "Set", material: "Flame Retardant Fabric", description: "Constant flow escape breathing apparatus providing 15 minutes of breathable air with clear view hood.", activeListingsCount: 22 },
    { code: "33 01 01", issaCode: "33.010.01", name: "Lifejacket SOLAS Adult with Whistle & Retro-Reflective Tape", unit: "Pcs", material: "Polyethylene Foam / Nylon", description: "Inherent buoyancy lifejacket complying with SOLAS/IMO LSA Code for persons over 43kg.", activeListingsCount: 38 },
    { code: "33 01 38", issaCode: "33.013.38", name: "Lifejacket Light Water-Activated LED Flash", unit: "Pcs", material: "ABS Marine Grade", description: "5-year lithium battery water-activated flashing light with manual off switch for lifejackets.", activeListingsCount: 19 },
    { code: "33 01 21", issaCode: "33.012.21", name: "Immersion Suit Insulated (Survival Suit) with Harness", unit: "Pcs", material: "5mm Neoprene Waterproof", description: "Thermal protective immersion suit providing up to 6 hours hypothermia protection in freezing water.", activeListingsCount: 11 },
    { code: "33 02 01", issaCode: "33.020.01", name: "Hydrostatic Release Unit Hammar H20 for Liferafts", unit: "Pcs", material: "Glass Fibre Reinforced", description: "Automatic water pressure activation release mechanism for liferafts at depth 1.5 - 4.0 meters.", activeListingsCount: 17 }
  ],
  "21": [
    { code: "21 04 43", issaCode: "21.044.43", name: "Mooring Rope Polypropylene 8-Strand 40mm x 220m", unit: "Coil", material: "High Tenacity PP", description: "Floating synthetic 8-strand plaited mooring line with spliced eyes at both ends. High UV resistance.", activeListingsCount: 26 },
    { code: "21 04 45", issaCode: "21.044.45", name: "Mooring Rope Polypropylene 8-Strand 48mm x 220m", unit: "Coil", material: "High Tenacity PP", description: "Heavy duty ship mooring hawser, breaking strength 320 kN, OCIMF MEG4 compliant.", activeListingsCount: 18 },
    { code: "21 09 15", issaCode: "21.091.15", name: "HMPE / Dyneema High Performance Mooring Rope 12-Strand 24mm", unit: "Coil", material: "Ultra High Molecular Weight PE", description: "Ultra-low elongation wire replacement synthetic rope. Extremely lightweight and floats on water.", activeListingsCount: 9 },
    { code: "21 01 05", issaCode: "21.010.05", name: "Nylon Mooring Hawser 8-Strand Double Braid 64mm", unit: "Coil", material: "Polyamide (Nylon)", description: "High elasticity shock absorbing rope suitable for single point moorings (SPM) and heavy swells.", activeListingsCount: 12 }
  ],
  "75": [
    { code: "75 01 02", issaCode: "75.010.02", name: "Marine Cast Iron Flanged Globe Valve JIS F7305 10K 50A", unit: "Pcs", material: "Cast Iron FC200 / Bronze Trim", description: "Straight type shut-off globe valve for sea water, fuel oil, and lube oil pipeline systems.", activeListingsCount: 15 },
    { code: "75 04 11", issaCode: "75.041.11", name: "Wafer Type Marine Butterfly Valve Centric JIS 10K 100A", unit: "Pcs", material: "Ductile Iron / NBR Liner / SS316 Disc", description: "Bi-directional lever operated butterfly valve suitable for ballast and cooling water service.", activeListingsCount: 24 },
    { code: "75 09 30", issaCode: "75.093.30", name: "Marine Storm Valve Vertical Type Flanged JIS F7353 5K 80A", unit: "Pcs", material: "Bronze / Cast Iron", description: "Non-return storm discharge valve with closing mechanism for sanitary and deck drain overboard lines.", activeListingsCount: 8 }
  ]
};

export default function ImpaSectionDetailPage({ params }: { params: Promise<{ section: string }> }) {
  const resolvedParams = use(params);
  const sectionCode = resolvedParams.section;
  const [searchQuery, setSearchQuery] = useState("");

  const items = SAMPLE_IMPA_ITEMS[sectionCode] || [
    { code: `${sectionCode} 01 01`, issaCode: `${sectionCode}.010.01`, name: `Standard Marine Item Group ${sectionCode} Part 1`, unit: "Pcs", material: "Standard Marine Grade", description: "Full technical specifications and supplier listings available for this IMPA code.", activeListingsCount: 5 },
    { code: `${sectionCode} 02 15`, issaCode: `${sectionCode}.021.15`, name: `Heavy Duty Equipment Group ${sectionCode} Part 2`, unit: "Set", material: "Stainless Steel 316", description: "Tested in accordance with marine classification society standards.", activeListingsCount: 8 },
    { code: `${sectionCode} 04 30`, issaCode: `${sectionCode}.043.30`, name: `Replacement Component Group ${sectionCode} Part 3`, unit: "Pcs", material: "Cast Bronze / Polymer", description: "Direct OEM replacement part with global port delivery availability.", activeListingsCount: 12 }
  ];

  const filteredItems = items.filter(i => 
    i.code.includes(searchQuery) ||
    i.name.toLowerCase().includes(searchQuery.toLowerCase()) ||
    i.description.toLowerCase().includes(searchQuery.toLowerCase())
  );

  return (
    <>
      <Navbar />
      <main className="min-h-screen bg-background pt-24 pb-20">
        <div className="container mx-auto px-6">
          
          {/* Back Navigation */}
          <div className="mb-6">
            <Link 
              href="/impa-codes"
              className="inline-flex items-center gap-2 text-sm text-muted-foreground hover:text-primary transition-colors"
            >
              <ArrowLeft size={16} />
              <span>Back to all IMPA Sections</span>
            </Link>
          </div>

          {/* Section Header */}
          <div className="glass-card p-8 rounded-3xl border border-border mb-8 flex flex-col md:flex-row md:items-center justify-between gap-6">
            <div className="flex items-center gap-5">
              <div className="w-16 h-16 rounded-2xl bg-gradient-to-tr from-primary to-blue-500 text-white font-black text-2xl flex items-center justify-center shadow-lg shadow-primary/20">
                {sectionCode}
              </div>
              <div>
                <span className="text-xs font-semibold text-primary uppercase tracking-wider">IMPA 2-Digit Major Division</span>
                <h1 className="text-2xl md:text-3xl font-bold text-foreground">
                  Section {sectionCode} Catalog Items
                </h1>
                <p className="text-sm text-muted-foreground mt-1">
                  6-digit marine codes with standard descriptions, units of measure, and active supplier inventory.
                </p>
              </div>
            </div>

            <div className="flex items-center gap-3">
              <Link
                href={`/listings?impa=${sectionCode}`}
                className="px-5 py-3 rounded-xl bg-primary text-white text-sm font-semibold hover:bg-primary/90 transition-colors flex items-center gap-2 shadow-md"
              >
                <Anchor size={16} />
                <span>View Marketplace Listings ({items.reduce((a,b) => a + b.activeListingsCount, 0)})</span>
              </Link>
            </div>
          </div>

          {/* Quick Search */}
          <div className="glass-card p-3 rounded-2xl mb-8 flex items-center gap-3 border border-border">
            <Search className="text-muted-foreground ml-3" size={18} />
            <input
              type="text"
              value={searchQuery}
              onChange={(e) => setSearchQuery(e.target.value)}
              placeholder={`Search in Section ${sectionCode} by 6-digit code or name...`}
              className="bg-transparent border-none outline-none w-full text-foreground placeholder:text-muted-foreground text-sm"
            />
          </div>

          {/* Codes Table / Cards */}
          <div className="space-y-4">
            {filteredItems.map((item, idx) => (
              <motion.div
                key={item.code}
                initial={{ opacity: 0, y: 10 }}
                animate={{ opacity: 1, y: 0 }}
                transition={{ duration: 0.2, delay: idx * 0.05 }}
                className="glass-card p-6 rounded-2xl border border-border hover:border-primary/50 transition-all group"
              >
                <div className="flex flex-col lg:flex-row lg:items-center justify-between gap-4">
                  
                  {/* Left info */}
                  <div className="flex-1 min-w-0">
                    <div className="flex flex-wrap items-center gap-3 mb-2">
                      <span className="font-mono font-bold text-base text-primary bg-primary/10 px-3 py-1 rounded-lg">
                        IMPA: {item.code}
                      </span>
                      <span className="font-mono text-xs text-muted-foreground bg-muted px-2.5 py-1 rounded-lg">
                        ISSA: {item.issaCode}
                      </span>
                      <span className="text-xs font-semibold text-green-600 dark:text-green-400 bg-green-500/10 px-2.5 py-1 rounded-lg flex items-center gap-1">
                        <ShieldCheck size={12} />
                        Standard Standardized
                      </span>
                    </div>

                    <h3 className="text-lg font-bold text-foreground group-hover:text-primary transition-colors mb-2">
                      {item.name}
                    </h3>

                    <p className="text-sm text-muted-foreground leading-relaxed mb-3">
                      {item.description}
                    </p>

                    <div className="flex flex-wrap items-center gap-4 text-xs text-muted-foreground">
                      <span><strong>Unit:</strong> {item.unit}</span>
                      <span>•</span>
                      <span><strong>Material / Spec:</strong> {item.material}</span>
                    </div>
                  </div>

                  {/* Right actions */}
                  <div className="flex flex-row lg:flex-col items-center lg:items-end justify-between gap-3 border-t lg:border-t-0 pt-4 lg:pt-0 border-border">
                    <span className="text-xs font-medium text-muted-foreground">
                      <strong>{item.activeListingsCount}</strong> suppliers stock this
                    </span>

                    <Link
                      href={`/listings?q=${encodeURIComponent(item.code)}`}
                      className="px-4 py-2.5 rounded-xl bg-primary/10 hover:bg-primary text-primary hover:text-white font-semibold text-sm transition-all flex items-center gap-1.5"
                    >
                      <span>Find Suppliers</span>
                      <ExternalLink size={14} />
                    </Link>
                  </div>

                </div>
              </motion.div>
            ))}
          </div>

        </div>
      </main>
    </>
  );
}
