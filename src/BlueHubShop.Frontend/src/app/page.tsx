"use client";

import React, { useState, useEffect } from "react";
import { Navbar } from "@/components/navbar";
import { Hero } from "@/components/hero";
import { ProductCard, ProductListing } from "@/components/product-card";
import { 
  Flame, Clock, ShieldCheck, ArrowRight, Star, ChevronRight, 
  Anchor, Zap, Ship, Award, CheckCircle2, MapPin, 
  Building2, BookOpen, Layers, Phone, Send, Sparkles,
  TrendingUp, Radio, Wrench, Shield, Droplets, Package,
  Gauge, LifeBuoy, AlertCircle, RefreshCw
} from "lucide-react";
import { motion } from "framer-motion";
import Link from "next/link";
import { apiClient, ApiProduct, ApiCategory, ApiCompany } from "@/lib/api";

// Flash Deals Campaign Items
const FLASH_DEALS = [
  {
    id: "deal-1",
    title: "Yokohama Type Pneumatic Rubber Fender 1.5m x 3.0m (50kPa)",
    impaCode: "23 21 04",
    partNo: "YOKO-PN-1530",
    originalPrice: 4200,
    discountPrice: 3450,
    currency: "USD",
    discountPercent: 18,
    category: "Deck Machinery & Fenders",
    stockLeft: 4,
    supplierName: "TRC Marine / Global Stockist",
    port: "Tuzla / Rotterdam",
    image: "/images/hero-bg.jpg"
  },
  {
    id: "deal-2",
    title: "Desmi Modular S Self-Priming Centrifugal Pump S80-70-220N",
    impaCode: "13 01 22",
    partNo: "DESMI-S80-70",
    originalPrice: 3100,
    discountPrice: 2480,
    currency: "USD",
    discountPercent: 20,
    category: "Engine Room & Pumps",
    stockLeft: 2,
    supplierName: "TRC Marine / Global Stockist",
    port: "Istanbul / Singapore",
    image: "/images/hero-bg.jpg"
  },
  {
    id: "deal-3",
    title: "SOLAS / MED Approved 12-Strand High-Tenacity Polypropylene Mooring Rope 64mm",
    impaCode: "21 04 43",
    partNo: "PP-12S-64MM",
    originalPrice: 1850,
    discountPrice: 1480,
    currency: "USD",
    discountPercent: 20,
    category: "Ropes & Mooring",
    stockLeft: 6,
    supplierName: "TRC Marine / Global Stockist",
    port: "Tuzla / Aliaga / Yalova",
    image: "/images/hero-bg.jpg"
  }
];

const POPULAR_IMPA_SECTIONS = [
  { code: "21", name: "Ropes, Hawsers & Mooring Lines", count: "1,970+ Items", icon: Anchor },
  { code: "33", name: "Safety Equipment (LSA / SOLAS / FFA)", count: "3,270+ Items", icon: LifeBuoy },
  { code: "75", name: "Valves & Cocks (Marine DIN/JIS)", count: "3,200+ Items", icon: Gauge },
  { code: "37", name: "Nautical & NavCom Electronics", count: "2,040+ Items", icon: Radio },
  { code: "13", name: "Pumps & Pumping Equipment", count: "1,450+ Items", icon: Droplets },
  { code: "59", name: "Pneumatic & Deck Scaling Tools", count: "1,520+ Items", icon: Wrench },
  { code: "81", name: "Ex-Proof Marine Lighting Fixtures", count: "2,860+ Items", icon: Zap },
  { code: "23", name: "Rigging Hardware & Shackles", count: "2,550+ Items", icon: Layers },
];

export default function Home() {
  const [featuredProducts, setFeaturedProducts] = useState<ProductListing[]>([]);
  const [categories, setCategories] = useState<ApiCategory[]>([]);
  const [topSuppliers, setTopSuppliers] = useState<ApiCompany[]>([]);
  const [activeTab, setActiveTab] = useState<"trending" | "new" | "deck" | "safety">("trending");
  const [isLoadingProducts, setIsLoadingProducts] = useState(true);

  // Live Countdown for Flash Deals (14h 35m 20s)
  const [timeLeft, setTimeLeft] = useState({ hours: 14, minutes: 35, seconds: 20 });

  useEffect(() => {
    const timer = setInterval(() => {
      setTimeLeft(prev => {
        if (prev.seconds > 0) return { ...prev, seconds: prev.seconds - 1 };
        if (prev.minutes > 0) return { ...prev, minutes: 59, seconds: 59 };
        if (prev.hours > 0) return { ...prev, hours: prev.hours - 1, minutes: 59, seconds: 59 };
        return { hours: 24, minutes: 0, seconds: 0 };
      });
    }, 1000);
    return () => clearInterval(timer);
  }, []);

  // Load live products, categories, and top suppliers from API
  useEffect(() => {
    let isMounted = true;

    async function loadData() {
      setIsLoadingProducts(true);

      const [prodRes, catRes, compRes] = await Promise.all([
        apiClient.getProducts({ pageSize: 8 }),
        apiClient.getCategories(),
        apiClient.getCompanies()
      ]);

      if (!isMounted) return;

      if (prodRes && prodRes.items) {
        const mapped: ProductListing[] = prodRes.items.map(item => ({
          id: item.id.toString(),
          title: item.title,
          impaCode: item.impaCode,
          issaCode: item.issaCode,
          oemPartNo: item.oemPartNo,
          price: item.price ? item.price.toLocaleString("en-US", { minimumFractionDigits: 2 }) : undefined,
          currency: item.currency || "USD",
          image: item.image || "/images/hero-bg.jpg",
          supplierName: item.supplierName || "Verified Maritime Stockist",
          location: item.supplierLocation || "Tuzla / Istanbul, Turkey",
          portOfDelivery: item.deliveryPorts || ["Tuzla", "Rotterdam", "Singapore"],
          isVerified: item.isVerified,
          category: item.category || "Marine Equipment"
        }));
        setFeaturedProducts(mapped);
      }

      if (catRes) {
        setCategories(catRes.slice(0, 6));
      }

      if (compRes) {
        setTopSuppliers(compRes.slice(0, 4));
      }

      setIsLoadingProducts(false);
    }

    loadData();
    return () => { isMounted = false; };
  }, []);

  return (
    <>
      <Navbar />
      <main className="min-h-screen bg-background overflow-hidden">
        
        {/* 1. Hero Section */}
        <Hero />

        {/* 2. Flash Deals & Campaign Banners (High Contrast Navy & Pure White Cards) */}
        <section className="py-16 bg-gradient-to-br from-slate-900 via-slate-950 to-blue-950 text-white relative overflow-hidden border-y border-white/10">
          <div className="absolute top-0 right-0 w-96 h-96 bg-sky-500/15 rounded-full blur-3xl pointer-events-none" />
          
          <div className="container mx-auto px-6 relative z-10 space-y-8">
            
            {/* Flash Deals Header */}
            <div className="flex flex-col md:flex-row md:items-center justify-between gap-4">
              <div className="space-y-1">
                <div className="flex items-center gap-2 text-xs font-bold text-amber-400 uppercase tracking-widest">
                  <Flame size={16} className="text-amber-400 animate-pulse" />
                  <span>Limited Time Port Stock Clearance</span>
                </div>
                <h2 className="text-2xl md:text-3xl font-black tracking-tight text-white">
                  Flash Port Deals & Urgent Stock Spares
                </h2>
              </div>

              {/* Countdown Timer */}
              <div className="flex items-center gap-2">
                <span className="text-xs font-semibold text-slate-300 mr-2 flex items-center gap-1.5">
                  <Clock size={14} className="text-sky-400" />
                  <span>Deals Expire In:</span>
                </span>
                <div className="flex items-center gap-1.5 font-mono text-sm font-bold">
                  <span className="px-3 py-1.5 rounded-xl bg-white/15 border border-white/20 text-white shadow-sm">{String(timeLeft.hours).padStart(2, "0")}h</span>
                  <span className="text-white">:</span>
                  <span className="px-3 py-1.5 rounded-xl bg-white/15 border border-white/20 text-white shadow-sm">{String(timeLeft.minutes).padStart(2, "0")}m</span>
                  <span className="text-white">:</span>
                  <span className="px-3 py-1.5 rounded-xl bg-sky-500 text-white shadow-md">{String(timeLeft.seconds).padStart(2, "0")}s</span>
                </div>
              </div>
            </div>

            {/* Campaign Cards Grid (Translucent Dark Glass with Crisp White & Red Details) */}
            <div className="grid grid-cols-1 md:grid-cols-3 gap-6">
              {FLASH_DEALS.map((deal) => (
                <div 
                  key={deal.id}
                  className="bg-slate-900/80 backdrop-blur-xl p-6 rounded-3xl border border-white/20 hover:border-sky-400/60 transition-all flex flex-col justify-between group space-y-4 shadow-xl"
                >
                  <div className="space-y-3">
                    <div className="flex items-center justify-between">
                      <span className="px-3 py-1 rounded-full bg-red-500/20 text-red-400 font-black text-xs border border-red-500/40">
                        SAVE {deal.discountPercent}%
                      </span>
                      <span className="text-xs font-mono text-slate-300 font-bold bg-white/10 px-2.5 py-0.5 rounded-md">
                        IMPA {deal.impaCode}
                      </span>
                    </div>

                    <h3 className="font-bold text-base text-white group-hover:text-sky-400 transition-colors line-clamp-2 leading-snug">
                      {deal.title}
                    </h3>

                    <div className="flex items-center gap-2 text-xs text-slate-300 font-medium">
                      <MapPin size={14} className="text-sky-400 flex-shrink-0" />
                      <span>Ready Port: {deal.port}</span>
                    </div>

                    {/* Pricing */}
                    <div className="pt-2 flex items-baseline gap-3">
                      <span className="text-2xl font-black text-white">
                        ${deal.discountPrice.toLocaleString()} {deal.currency}
                      </span>
                      <span className="text-sm line-through text-slate-400">
                        ${deal.originalPrice.toLocaleString()}
                      </span>
                    </div>

                    {/* Stock Progress Bar */}
                    <div className="space-y-1.5">
                      <div className="flex justify-between text-xs text-slate-300">
                        <span>Stock Available</span>
                        <span className="text-amber-400 font-bold">{deal.stockLeft} Units Left</span>
                      </div>
                      <div className="w-full h-2 rounded-full bg-white/15 overflow-hidden">
                        <div className="h-full bg-gradient-to-r from-amber-400 to-red-500 rounded-full" style={{ width: `${(deal.stockLeft / 10) * 100}%` }} />
                      </div>
                    </div>
                  </div>

                  <Link
                    href={`/listings?search=${encodeURIComponent(deal.impaCode)}`}
                    className="w-full py-3 rounded-xl bg-sky-500 hover:bg-sky-400 text-white text-xs font-bold transition-all shadow-md flex items-center justify-center gap-2 cursor-pointer"
                  >
                    <span>Request Flash Quote</span>
                    <ArrowRight size={14} />
                  </Link>
                </div>
              ))}
            </div>

          </div>
        </section>

        {/* 3. Featured Categories Section */}
        <section className="py-20 bg-background">
          <div className="container mx-auto px-6 space-y-12">
            
            <div className="flex flex-col md:flex-row md:items-end justify-between gap-4">
              <div>
                <div className="flex items-center gap-2 text-xs font-bold text-sky-600 dark:text-sky-400 uppercase tracking-wider mb-1">
                  <Layers size={14} />
                  <span>Curated Maritime Taxonomy</span>
                </div>
                <h2 className="text-3xl md:text-4xl font-black tracking-tight text-slate-900 dark:text-white">
                  Explore Essential Marine Categories
                </h2>
                <p className="text-sm text-slate-600 dark:text-slate-400 mt-1">
                  Browse over 4,900+ equipment types and spare parts categorized to marine standards.
                </p>
              </div>

              <Link 
                href="/categories"
                className="inline-flex items-center gap-1 text-sm font-bold text-sky-600 dark:text-sky-400 hover:underline"
              >
                <span>View Full Category Tree</span>
                <ChevronRight size={16} />
              </Link>
            </div>

            {/* Category Cards Grid */}
            <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-6">
              {[
                { title: "Deck Machinery & Mooring", count: "1,840 Items", icon: Anchor, desc: "Synthetic ropes, studlink chains, anchors, Yokohama fenders, and container lashings.", code: "deck" },
                { title: "Engine Room Spares & Machinery", count: "2,400 Items", icon: Wrench, desc: "Centrifugal pumps, air compressors, purifiers, plate heat exchangers, and filters.", code: "engine" },
                { title: "Bridge NavCom & GMDSS", count: "890 Items", icon: Radio, desc: "Marine radars, gyrocompasses, VHF/MF radios, AIS transponders, and GPS receivers.", code: "navcom" },
                { title: "Safety & SOLAS / LSA Equipment", count: "1,250 Items", icon: LifeBuoy, desc: "SOLAS lifejackets, immersion suits, EEBD, SCBA sets, fire hoses, and pyrotechnics.", code: "safety" },
                { title: "Valves, Pipes & Flange Fittings", count: "3,100 Items", icon: Gauge, desc: "DIN & JIS globe valves, butterfly valves, storm valves, seamless pipes, and gaskets.", code: "valves" },
                { title: "Chemicals, Lubes & Hold Cleaning", count: "780 Items", icon: Droplets, desc: "Carbon removers, cargo hold wash, marine cylinder lubricants, and tank coatings.", code: "chemicals" }
              ].map((cat) => (
                <Link
                  key={cat.title}
                  href={`/listings?search=${encodeURIComponent(cat.title.split(" ")[0])}`}
                  className="glass-card rounded-3xl p-6 border border-slate-200/90 dark:border-slate-800 flex flex-col justify-between group space-y-4 cursor-pointer"
                >
                  <div className="space-y-3">
                    <div className="flex items-center justify-between">
                      <div className="w-12 h-12 rounded-2xl bg-sky-50 dark:bg-sky-950/60 border border-sky-200 dark:border-sky-800 flex items-center justify-center text-sky-600 dark:text-sky-400 group-hover:scale-105 transition-transform">
                        <cat.icon size={24} />
                      </div>
                      <span className="text-xs font-bold px-3 py-1 rounded-full bg-slate-100 dark:bg-slate-800 text-slate-700 dark:text-slate-300">
                        {cat.count}
                      </span>
                    </div>

                    <h3 className="font-extrabold text-base text-slate-900 dark:text-white group-hover:text-sky-600 dark:group-hover:text-sky-400 transition-colors">
                      {cat.title}
                    </h3>

                    <p className="text-xs text-slate-600 dark:text-slate-400 leading-relaxed line-clamp-2">
                      {cat.desc}
                    </p>
                  </div>

                  <div className="pt-3 border-t border-slate-200/80 dark:border-slate-800 flex items-center justify-between text-xs font-bold text-sky-600 dark:text-sky-400 group-hover:translate-x-1 transition-transform">
                    <span>Browse Equipment</span>
                    <ChevronRight size={14} />
                  </div>
                </Link>
              ))}
            </div>

          </div>
        </section>

        {/* 4. Live Featured Marine Products Vitrini */}
        <section className="py-20 bg-slate-100/60 dark:bg-slate-900/40 border-y border-slate-200/90 dark:border-white/10">
          <div className="container mx-auto px-6 space-y-10">
            
            <div className="flex flex-col md:flex-row md:items-end justify-between gap-4">
              <div>
                <div className="flex items-center gap-2 text-xs font-bold text-sky-600 dark:text-sky-400 uppercase tracking-wider mb-1">
                  <Sparkles size={14} />
                  <span>Direct Database Stock</span>
                </div>
                <h2 className="text-3xl md:text-4xl font-black tracking-tight text-slate-900 dark:text-white">
                  Featured Maritime Equipment & Spares
                </h2>
                <p className="text-sm text-slate-600 dark:text-slate-400 mt-1">
                  Real-time stock availability with certified class test approvals.
                </p>
              </div>

              {/* Tabs */}
              <div className="flex items-center gap-2 p-1.5 rounded-2xl bg-white dark:bg-slate-900 border border-slate-200/90 dark:border-slate-800 overflow-x-auto shadow-sm">
                {[
                  { id: "trending", label: "Top In-Stock" },
                  { id: "new", label: "New Arrivals" },
                  { id: "deck", label: "Heavy Machinery" },
                  { id: "safety", label: "SOLAS Safety" }
                ].map(tab => (
                  <button
                    key={tab.id}
                    onClick={() => setActiveTab(tab.id as any)}
                    className={`px-4 py-2 rounded-xl text-xs font-bold transition-all cursor-pointer whitespace-nowrap ${
                      activeTab === tab.id
                        ? "bg-sky-600 text-white shadow-md shadow-sky-600/30"
                        : "text-slate-600 dark:text-slate-300 hover:text-slate-900 dark:hover:text-white"
                    }`}
                  >
                    {tab.label}
                  </button>
                ))}
              </div>
            </div>

            {/* Products Grid */}
            {isLoadingProducts ? (
              <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
                {[1, 2, 3, 4, 5, 6, 7, 8].map((i) => (
                  <div key={i} className="glass-card rounded-3xl p-5 border border-slate-200/90 dark:border-slate-800 animate-pulse space-y-4">
                    <div className="w-full h-44 bg-slate-200 dark:bg-slate-800 rounded-2xl" />
                    <div className="h-4 bg-slate-200 dark:bg-slate-800 rounded-full w-3/4" />
                    <div className="h-3 bg-slate-200 dark:bg-slate-800 rounded-full w-1/2" />
                  </div>
                ))}
              </div>
            ) : featuredProducts.length > 0 ? (
              <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
                {featuredProducts.map((product, index) => (
                  <ProductCard key={product.id} product={product} index={index} />
                ))}
              </div>
            ) : (
              <div className="glass-card p-12 rounded-3xl text-center border border-slate-200/90 dark:border-slate-800">
                <p className="text-sm text-slate-600 dark:text-slate-400">Loading products from database...</p>
              </div>
            )}

            <div className="text-center pt-4">
              <Link
                href="/listings"
                className="inline-flex items-center gap-2 px-8 py-4 rounded-full bg-sky-600 hover:bg-sky-500 text-white font-bold text-sm transition-all hover:scale-105 shadow-xl shadow-sky-600/30 cursor-pointer"
              >
                <span>Browse All 4,900+ Products in Catalog</span>
                <ArrowRight size={16} />
              </Link>
            </div>

          </div>
        </section>

        {/* 5. Top-Rated Marine Stockists & Chandlers */}
        <section className="py-20 bg-background">
          <div className="container mx-auto px-6 space-y-12">
            
            <div className="flex flex-col md:flex-row md:items-end justify-between gap-4">
              <div>
                <div className="flex items-center gap-2 text-xs font-bold text-sky-600 dark:text-sky-400 uppercase tracking-wider mb-1">
                  <Building2 size={14} />
                  <span>Verified Supply Partners</span>
                </div>
                <h2 className="text-3xl md:text-4xl font-black tracking-tight text-slate-900 dark:text-white">
                  Top-Rated Ship Chandlers & Stockists
                </h2>
                <p className="text-sm text-slate-600 dark:text-slate-400 mt-1">
                  Direct stockist attendance in key drydocks, anchorages, and container terminals.
                </p>
              </div>

              <Link 
                href="/stores"
                className="inline-flex items-center gap-1 text-sm font-bold text-sky-600 dark:text-sky-400 hover:underline"
              >
                <span>Browse All Suppliers</span>
                <ChevronRight size={16} />
              </Link>
            </div>

            {/* Suppliers Grid */}
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-6">
              {topSuppliers.length > 0 ? (
                topSuppliers.map((sup) => (
                  <div 
                    key={sup.id}
                    className="glass-card rounded-3xl p-6 border border-slate-200/90 dark:border-slate-800 flex flex-col justify-between group space-y-4"
                  >
                    <div className="space-y-3">
                      <div className="flex items-start justify-between gap-2">
                        <div className="w-12 h-12 rounded-2xl bg-sky-50 dark:bg-sky-950/60 border border-sky-200 dark:border-sky-800 flex items-center justify-center text-sky-600 dark:text-sky-400 font-black text-xl">
                          <Building2 size={24} />
                        </div>
                        {sup.isVerified && (
                          <span className="p-1.5 rounded-xl bg-blue-500/10 text-blue-600 dark:text-blue-400" title="Verified Chandler">
                            <ShieldCheck size={18} />
                          </span>
                        )}
                      </div>

                      <div>
                        <h3 className="font-bold text-base text-slate-900 dark:text-white group-hover:text-sky-600 dark:group-hover:text-sky-400 transition-colors line-clamp-1">
                          {sup.name}
                        </h3>
                        <p className="text-xs font-semibold text-sky-600 dark:text-sky-400 mt-0.5">
                          {sup.companyType || "Marine Equipment Specialist"}
                        </p>
                      </div>

                      <div className="space-y-1.5 text-xs text-slate-600 dark:text-slate-300">
                        <div className="flex items-center gap-1.5">
                          <MapPin size={13} className="text-sky-600 dark:text-sky-400 flex-shrink-0" />
                          <span className="truncate">{sup.city || "Tuzla / Istanbul"}, {sup.country || "Turkey"}</span>
                        </div>
                        <div className="flex items-center gap-1.5">
                          <Clock size={13} className="text-sky-600 dark:text-sky-400 flex-shrink-0" />
                          <span>Avg Response: &lt; 1 Hour</span>
                        </div>
                      </div>
                    </div>

                    <Link
                      href={`/listings?supplier=${sup.id}`}
                      className="w-full py-2.5 rounded-xl bg-sky-50 dark:bg-sky-950/60 hover:bg-sky-600 text-sky-700 dark:text-sky-300 hover:text-white font-bold text-xs transition-colors flex items-center justify-center gap-1 cursor-pointer"
                    >
                      <span>View Stock Catalog</span>
                      <ChevronRight size={14} />
                    </Link>
                  </div>
                ))
              ) : (
                <div className="col-span-4 glass-card p-8 rounded-3xl text-center border border-slate-200/90 dark:border-slate-800">
                  <p className="text-sm text-slate-600 dark:text-slate-400">Connecting with verified maritime suppliers...</p>
                </div>
              )}
            </div>

          </div>
        </section>

        {/* 6. Quick IMPA Marine Stores Guide Browser (High-Contrast White Theme Support) */}
        <section className="py-20 bg-slate-100/80 dark:bg-slate-950 border-y border-slate-200/90 dark:border-white/10">
          <div className="container mx-auto px-6 space-y-10">
            
            <div className="max-w-3xl space-y-2">
              <div className="flex items-center gap-2 text-xs font-bold text-sky-600 dark:text-sky-400 uppercase tracking-widest">
                <BookOpen size={16} />
                <span>Standard Maritime Catalog</span>
              </div>
              <h2 className="text-3xl md:text-4xl font-black tracking-tight text-slate-900 dark:text-white">
                Quick IMPA Marine Stores Guide Navigation
              </h2>
              <p className="text-sm text-slate-600 dark:text-slate-400">
                Directly jump to 2-digit international standard IMPA product classifications.
              </p>
            </div>

            {/* IMPA Code Chips Grid (Crisp White Cards with Dark Text on Light Mode) */}
            <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-4">
              {POPULAR_IMPA_SECTIONS.map((sec) => (
                <Link
                  key={sec.code}
                  href={`/listings?impaCode=${sec.code}`}
                  className="bg-white dark:bg-slate-900 p-5 rounded-2xl border border-slate-200/90 dark:border-slate-800 hover:border-sky-500 dark:hover:border-sky-400 transition-all flex items-center justify-between group cursor-pointer shadow-sm hover:shadow-md"
                >
                  <div className="flex items-center gap-3">
                    <div className="w-10 h-10 rounded-xl bg-sky-50 dark:bg-sky-950/80 text-sky-700 dark:text-sky-400 font-black text-sm flex items-center justify-center border border-sky-200 dark:border-sky-800 flex-shrink-0">
                      {sec.code}
                    </div>
                    <div>
                      <h4 className="text-xs font-extrabold text-slate-900 dark:text-white group-hover:text-sky-600 dark:group-hover:text-sky-400 transition-colors line-clamp-1">
                        {sec.name}
                      </h4>
                      <p className="text-[11px] text-slate-500 dark:text-slate-400 font-mono font-medium mt-0.5">
                        {sec.count}
                      </p>
                    </div>
                  </div>
                  <ChevronRight size={16} className="text-slate-400 group-hover:text-sky-600 dark:group-hover:text-sky-400 group-hover:translate-x-1 transition-all flex-shrink-0" />
                </Link>
              ))}
            </div>

            <div className="pt-2 flex justify-end">
              <Link
                href="/impa-codes"
                className="text-xs font-bold text-sky-600 dark:text-sky-400 hover:underline flex items-center gap-1"
              >
                <span>Open Full 40+ Section IMPA Catalog</span>
                <ChevronRight size={14} />
              </Link>
            </div>

          </div>
        </section>

        {/* 7. B2B Trust & Global Port Logistics */}
        <section className="py-20 bg-background">
          <div className="container mx-auto px-6 space-y-12">
            
            <div className="max-w-2xl mx-auto text-center space-y-2">
              <span className="text-xs font-bold text-sky-600 dark:text-sky-400 uppercase tracking-widest">
                Built For Shipowners, Technical Managers & Chandlers
              </span>
              <h2 className="text-3xl md:text-4xl font-black tracking-tight text-slate-900 dark:text-white">
                Why Global Fleets Trust BlueHubShop
              </h2>
            </div>

            <div className="grid grid-cols-1 md:grid-cols-3 gap-8">
              <div className="glass-card p-8 rounded-3xl border border-slate-200/90 dark:border-slate-800 space-y-4">
                <div className="w-14 h-14 rounded-2xl bg-sky-50 dark:bg-sky-950/60 text-sky-600 dark:text-sky-400 flex items-center justify-center border border-sky-200 dark:border-sky-800">
                  <Anchor size={28} />
                </div>
                <h3 className="text-lg font-bold text-slate-900 dark:text-white">24/7 Port & Anchorage Attendance</h3>
                <p className="text-xs text-slate-600 dark:text-slate-400 leading-relaxed">
                  Emergency supply delivery directly to shipside in Tuzla Shipyards, Istanbul Anchorage, Rotterdam Botlek, and Singapore Jurong.
                </p>
              </div>

              <div className="glass-card p-8 rounded-3xl border border-slate-200/90 dark:border-slate-800 space-y-4">
                <div className="w-14 h-14 rounded-2xl bg-emerald-50 dark:bg-emerald-950/60 text-emerald-600 dark:text-emerald-400 flex items-center justify-center border border-emerald-200 dark:border-emerald-800">
                  <ShieldCheck size={28} />
                </div>
                <h3 className="text-lg font-bold text-slate-900 dark:text-white">IACS Class & MED Certificates</h3>
                <p className="text-xs text-slate-600 dark:text-slate-400 leading-relaxed">
                  All critical safety gear, wire ropes, anchors, and valves are delivered with original DNV, ABS, or Wheelmark mill test certificates.
                </p>
              </div>

              <div className="glass-card p-8 rounded-3xl border border-slate-200/90 dark:border-slate-800 space-y-4">
                <div className="w-14 h-14 rounded-2xl bg-indigo-50 dark:bg-indigo-950/60 text-indigo-600 dark:text-indigo-400 flex items-center justify-center border border-indigo-200 dark:border-indigo-800">
                  <TrendingUp size={28} />
                </div>
                <h3 className="text-lg font-bold text-slate-900 dark:text-white">Digital RFQ & Fast B2B Quotes</h3>
                <p className="text-xs text-slate-600 dark:text-slate-400 leading-relaxed">
                  Upload your vessel requisition or search by IMPA/ISSA code to receive binding proforma invoices and delivery schedules in under 1 hour.
                </p>
              </div>
            </div>

          </div>
        </section>

        {/* 8. Urgent 1-Hour RFQ Quote Bar */}
        <section className="py-16 bg-gradient-to-r from-sky-600 to-blue-700 text-white">
          <div className="container mx-auto px-6">
            <div className="max-w-4xl mx-auto flex flex-col md:flex-row items-center justify-between gap-8">
              <div className="space-y-2 text-center md:text-left">
                <span className="text-xs font-extrabold uppercase tracking-widest text-white/80">
                  Urgent Vessel Requisition
                </span>
                <h2 className="text-2xl md:text-3xl font-black text-white">
                  Need Fast Port Supply for Your Vessel?
                </h2>
                <p className="text-xs md:text-sm text-sky-100 max-w-md">
                  Submit your IMPA codes or vessel spare parts list. Our technical stockists will quote within 60 minutes.
                </p>
              </div>

              <Link
                href="/listings"
                className="px-8 py-4 rounded-full bg-white text-sky-700 hover:bg-sky-50 font-black text-sm transition-transform hover:scale-105 shadow-2xl flex-shrink-0 cursor-pointer flex items-center gap-2"
              >
                <span>Request Quotation (RFQ)</span>
                <Send size={16} />
              </Link>
            </div>
          </div>
        </section>

        {/* 9. Comprehensive Footer */}
        <footer className="bg-slate-950 text-slate-400 pt-16 pb-12 border-t border-white/10 text-xs">
          <div className="container mx-auto px-6 grid grid-cols-1 md:grid-cols-4 gap-10 mb-12">
            
            {/* Col 1: Brand */}
            <div className="space-y-4">
              <div className="flex items-center gap-2 text-white font-black text-xl">
                <Ship className="text-sky-400" size={24} />
                <span>BlueHub<span className="text-sky-400">Shop</span></span>
              </div>
              <p className="text-slate-400 leading-relaxed">
                The global maritime marketplace connecting vessel operators, superintendents, and certified ship supply stockists worldwide.
              </p>
              <div className="flex items-center gap-2 text-slate-400">
                <MapPin size={14} className="text-sky-400" />
                <span>Istanbul • Rotterdam • Singapore</span>
              </div>
            </div>

            {/* Col 2: Marketplace */}
            <div className="space-y-3">
              <h4 className="font-bold text-white uppercase tracking-wider text-xs">Marketplace</h4>
              <ul className="space-y-2">
                <li><Link href="/listings" className="hover:text-sky-400 transition-colors">All Products & Spares</Link></li>
                <li><Link href="/categories" className="hover:text-sky-400 transition-colors">Marine Taxonomy Categories</Link></li>
                <li><Link href="/impa-codes" className="hover:text-sky-400 transition-colors">IMPA Stores Guide</Link></li>
                <li><Link href="/stores" className="hover:text-sky-400 transition-colors">Verified Stockists & Chandlers</Link></li>
              </ul>
            </div>

            {/* Col 3: Key Ports */}
            <div className="space-y-3">
              <h4 className="font-bold text-white uppercase tracking-wider text-xs">Supply Ports</h4>
              <ul className="space-y-2">
                <li><Link href="/listings?port=Tuzla" className="hover:text-sky-400 transition-colors">Tuzla & Yalova Shipyards</Link></li>
                <li><Link href="/listings?port=Rotterdam" className="hover:text-sky-400 transition-colors">Port of Rotterdam (Botlek)</Link></li>
                <li><Link href="/listings?port=Singapore" className="hover:text-sky-400 transition-colors">Port of Singapore (Jurong)</Link></li>
                <li><Link href="/listings?port=Houston" className="hover:text-sky-400 transition-colors">Port of Houston & US Gulf</Link></li>
              </ul>
            </div>

            {/* Col 4: Standards & Contact */}
            <div className="space-y-3">
              <h4 className="font-bold text-white uppercase tracking-wider text-xs">Class & Standards</h4>
              <ul className="space-y-2">
                <li className="flex items-center gap-1.5"><CheckCircle2 size={13} className="text-sky-400" /> <span>IMPA & ISSA Coded Items</span></li>
                <li className="flex items-center gap-1.5"><CheckCircle2 size={13} className="text-sky-400" /> <span>SOLAS / MED Wheelmark Certified</span></li>
                <li className="flex items-center gap-1.5"><CheckCircle2 size={13} className="text-sky-400" /> <span>IACS Class Certificate Guarantee</span></li>
                <li className="flex items-center gap-1.5"><CheckCircle2 size={13} className="text-sky-400" /> <span>24/7 Technical RFQ Support</span></li>
              </ul>
            </div>

          </div>

          <div className="container mx-auto px-6 pt-8 border-t border-white/10 flex flex-col sm:flex-row items-center justify-between gap-4 text-slate-500 text-[11px]">
            <div>
              © {new Date().getFullYear()} BlueHubShop. All rights reserved. Maritime B2B eCommerce Platform.
            </div>
            <div className="flex items-center gap-6">
              <span>Privacy Policy</span>
              <span>Terms of Maritime Trade</span>
              <span>Class Certifications</span>
            </div>
          </div>
        </footer>

      </main>
    </>
  );
}
