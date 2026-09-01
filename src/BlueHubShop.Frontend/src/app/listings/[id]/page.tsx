"use client";

import React, { useState, useEffect, use } from "react";
import { Navbar } from "@/components/navbar";
import { 
  ShieldCheck, MapPin, Building2, Anchor, Mail, Share2, 
  Heart, ExternalLink, MessageSquare, CheckCircle2, Clock, 
  Globe2, FileCheck2, AlertCircle, X, Send, Award, Layers,
  Loader2, PackageSearch, ArrowLeft, ShoppingCart, Plus, Minus,
  Truck, Shield, Download, FileText, Check, Phone, Copy, 
  Sparkles, Star, ChevronRight, Zap, RefreshCw, HelpCircle,
  Maximize2
} from "lucide-react";
import { motion, AnimatePresence } from "framer-motion";
import Image from "next/image";
import Link from "next/link";
import { apiClient, ApiProduct } from "@/lib/api";

export default function ListingDetailPage({ params }: { params: Promise<{ id: string }> }) {
  const resolvedParams = use(params);
  const id = resolvedParams.id;

  const [product, setProduct] = useState<any>(null);
  const [relatedProducts, setRelatedProducts] = useState<ApiProduct[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  
  // Gallery State
  const [selectedImageIndex, setSelectedImageIndex] = useState(0);
  const [isZoomModalOpen, setIsZoomModalOpen] = useState(false);

  // Buy Box & Quantity State
  const [quantity, setQuantity] = useState(1);
  const [selectedPort, setSelectedPort] = useState("Tuzla / Istanbul");
  const [isWishlisted, setIsWishlisted] = useState(false);
  const [copiedLink, setCopiedLink] = useState(false);
  const [cartToast, setCartToast] = useState(false);
  const [activeTab, setActiveTab] = useState<"overview" | "specs" | "certs" | "logistics" | "supplier">("overview");
  const [showStickyBar, setShowStickyBar] = useState(false);

  // RFQ Modal State
  const [isRfqModalOpen, setIsRfqModalOpen] = useState(false);
  const [rfqSubmitted, setRfqSubmitted] = useState(false);
  const [isSubmitting, setIsSubmitting] = useState(false);
  const [rfqForm, setRfqForm] = useState({
    vesselName: "",
    imoNumber: "",
    portOfDelivery: "Tuzla / Istanbul",
    etaDate: "",
    quantity: "1",
    notes: ""
  });

  // Load Product & Related Items
  useEffect(() => {
    async function loadProduct() {
      setIsLoading(true);
      const res = await apiClient.getProductById(id);
      if (res) {
        setProduct(res);
        setRfqForm(prev => ({
          ...prev,
          quantity: "1",
          portOfDelivery: res.deliveryPorts?.[0] || "Tuzla / Istanbul"
        }));
        setSelectedPort(res.deliveryPorts?.[0] || "Tuzla / Istanbul");
      } else {
        setProduct(null);
      }
      
      // Fetch related marine equipment
      const relatedRes = await apiClient.getProducts({ pageSize: 4 });
      if (relatedRes?.items) {
        setRelatedProducts(relatedRes.items.filter(item => item.id.toString() !== id));
      }
      setIsLoading(false);
    }
    loadProduct();
  }, [id]);

  // Scroll listener for sticky bottom bar
  useEffect(() => {
    const handleScroll = () => {
      if (window.scrollY > 450) {
        setShowStickyBar(true);
      } else {
        setShowStickyBar(false);
      }
    };
    window.addEventListener("scroll", handleScroll);
    return () => window.removeEventListener("scroll", handleScroll);
  }, []);

  // Copy share link
  const handleCopyLink = () => {
    navigator.clipboard.writeText(window.location.href);
    setCopiedLink(true);
    setTimeout(() => setCopiedLink(false), 2500);
  };

  // Add to cart handler
  const handleAddToCart = () => {
    setCartToast(true);
    setTimeout(() => setCartToast(false), 3000);
  };

  // RFQ Submission
  const handleRfqSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setIsSubmitting(true);
    
    await apiClient.submitRfq({
      productId: parseInt(id) || undefined,
      vesselName: rfqForm.vesselName,
      imoNumber: rfqForm.imoNumber,
      portOfDelivery: rfqForm.portOfDelivery,
      etaDate: rfqForm.etaDate || undefined,
      quantity: parseFloat(rfqForm.quantity) || quantity,
      notes: rfqForm.notes
    });

    setIsSubmitting(false);
    setRfqSubmitted(true);
    setTimeout(() => {
      setIsRfqModalOpen(false);
      setRfqSubmitted(false);
    }, 2500);
  };

  // Tiered Volume Pricing Calculation
  const unitPrice = product?.price || 0;
  const getDiscountedUnitPrice = (qty: number) => {
    if (!unitPrice) return 0;
    if (qty >= 20) return unitPrice * 0.85; // 15% discount for 20+
    if (qty >= 6) return unitPrice * 0.92;  // 8% discount for 6-19
    return unitPrice;
  };
  const effectiveUnitPrice = getDiscountedUnitPrice(quantity);
  const subtotal = effectiveUnitPrice * quantity;

  // Local Safe Image Gallery Construction
  const galleryImages = [
    product?.image || "/images/hero-bg.jpg",
    "/images/hero-day.jpg",
    "/images/hero-night.jpg",
    "/images/hero-bg.jpg"
  ];

  // Port Delivery Times dictionary
  const portLogistics: Record<string, { boatTime: string; status: string }> = {
    "Tuzla / Istanbul": { boatTime: "⚡ Launch Boat: 2-4 Hours", status: "Stock in Tuzla Warehouse" },
    "Tuzla": { boatTime: "⚡ Launch Boat: 2-4 Hours", status: "Stock in Tuzla Warehouse" },
    "Rotterdam": { boatTime: "🚢 Berth Delivery: 12-24 Hours", status: "EU Hub Distribution" },
    "Singapore": { boatTime: "⚓ Anchorage Supply: 4-8 Hours", status: "Jurong Island Express" },
    "Hamburg": { boatTime: "📦 Shipyard Express: 24 Hours", status: "Germany Central Hub" },
    "Houston": { boatTime: "✈️ Air Freight / Berth: 24-48 Hours", status: "US Gulf Depot" },
    "Dubai": { boatTime: "⚡ Anchorage Express: 6 Hours", status: "Jebel Ali Free Zone" },
    "Piraeus": { boatTime: "🚢 Launch Boat: 4-6 Hours", status: "Greece Hub Stock" },
    "Yalova": { boatTime: "⚡ Direct Shipyard Delivery: 2 Hours", status: "Yalova Bay Stock" }
  };

  if (isLoading) {
    return (
      <>
        <Navbar />
        <main className="min-h-screen bg-background pt-32 pb-20">
          <div className="container mx-auto px-6 max-w-7xl space-y-8 animate-pulse">
            <div className="h-6 bg-slate-200 dark:bg-slate-800 rounded-full w-64" />
            <div className="grid grid-cols-1 lg:grid-cols-12 gap-8">
              <div className="lg:col-span-7 space-y-6">
                <div className="h-96 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
                <div className="grid grid-cols-4 gap-4">
                  {[1, 2, 3, 4].map(i => (
                    <div key={i} className="h-24 bg-slate-200 dark:bg-slate-800 rounded-2xl" />
                  ))}
                </div>
                <div className="h-48 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
              </div>
              <div className="lg:col-span-5 space-y-6">
                <div className="h-80 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
                <div className="h-40 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
              </div>
            </div>
          </div>
        </main>
      </>
    );
  }

  if (!product) {
    return (
      <>
        <Navbar />
        <main className="min-h-screen bg-background pt-32 pb-20 flex items-center justify-center">
          <div className="glass-card p-12 rounded-3xl text-center max-w-lg mx-auto border border-border space-y-4">
            <PackageSearch size={54} className="mx-auto text-muted-foreground/40" />
            <h2 className="text-2xl font-bold text-foreground">Product #{id} Not Found</h2>
            <p className="text-sm text-muted-foreground">
              The requested marine equipment item was not found in the database.
            </p>
            <Link
              href="/listings"
              className="inline-flex items-center gap-2 px-6 py-3 rounded-xl bg-primary text-white font-semibold text-sm shadow-md hover:bg-primary/90 transition-colors"
            >
              <ArrowLeft size={16} />
              <span>Back to Marketplace</span>
            </Link>
          </div>
        </main>
      </>
    );
  }

  return (
    <>
      <Navbar />
      <main className="min-h-screen bg-background pt-24 pb-28">
        
        {/* Toast Notifications */}
        <AnimatePresence>
          {cartToast && (
            <motion.div
              initial={{ opacity: 0, y: -20, scale: 0.95 }}
              animate={{ opacity: 1, y: 0, scale: 1 }}
              exit={{ opacity: 0, y: -20, scale: 0.95 }}
              className="fixed top-24 right-6 z-50 flex items-center gap-3 px-5 py-4 rounded-2xl bg-slate-900 text-white dark:bg-white dark:text-slate-900 shadow-2xl border border-border"
            >
              <div className="w-8 h-8 rounded-full bg-green-500/20 text-green-500 flex items-center justify-center">
                <Check size={18} />
              </div>
              <div>
                <p className="text-xs font-bold">{quantity}x Item Added to RFQ Cart</p>
                <p className="text-[11px] text-muted-foreground opacity-80">{product.title.slice(0, 32)}...</p>
              </div>
            </motion.div>
          )}

          {copiedLink && (
            <motion.div
              initial={{ opacity: 0, y: -20 }}
              animate={{ opacity: 1, y: 0 }}
              exit={{ opacity: 0, y: -20 }}
              className="fixed top-24 right-6 z-50 flex items-center gap-2 px-4 py-3 rounded-xl bg-primary text-white text-xs font-bold shadow-xl"
            >
              <Check size={16} />
              <span>Product link copied to clipboard!</span>
            </motion.div>
          )}
        </AnimatePresence>

        {/* Top Breadcrumb & Quick Actions Bar */}
        <div className="container mx-auto px-6 mb-6">
          <div className="flex flex-col sm:flex-row sm:items-center justify-between gap-4">
            <div className="text-xs text-muted-foreground flex items-center gap-2 flex-wrap">
              <Link href="/" className="hover:text-primary transition-colors">Home</Link>
              <ChevronRight size={12} />
              <Link href="/listings" className="hover:text-primary transition-colors">Marketplace</Link>
              <ChevronRight size={12} />
              <span className="text-primary font-semibold">{product.category || "Marine Equipment"}</span>
              <ChevronRight size={12} />
              <span className="text-foreground font-medium truncate max-w-xs">{product.title}</span>
            </div>

            <div className="flex items-center gap-2 self-end sm:self-auto">
              <button
                onClick={handleCopyLink}
                className="flex items-center gap-1.5 px-3 py-1.5 rounded-xl bg-card border border-border text-xs font-semibold text-muted-foreground hover:text-foreground hover:border-primary/50 transition-all shadow-sm"
              >
                <Share2 size={13} />
                <span>Share</span>
              </button>

              <button
                onClick={() => setIsWishlisted(!isWishlisted)}
                className={`flex items-center gap-1.5 px-3 py-1.5 rounded-xl border text-xs font-semibold transition-all shadow-sm ${
                  isWishlisted 
                    ? "bg-rose-500/10 border-rose-500/30 text-rose-500" 
                    : "bg-card border-border text-muted-foreground hover:text-foreground hover:border-rose-500/30"
                }`}
              >
                <Heart size={13} className={isWishlisted ? "fill-rose-500" : ""} />
                <span>{isWishlisted ? "Saved" : "Save Item"}</span>
              </button>
            </div>
          </div>
        </div>

        {/* Main Product Showcase Grid */}
        <div className="container mx-auto px-6">
          <div className="grid grid-cols-1 lg:grid-cols-12 gap-8">
            
            {/* Left Column: Interactive Media Gallery & Technical Details (7 Cols) */}
            <div className="lg:col-span-7 space-y-8">
              
              {/* Product Header & Media Card */}
              <div className="glass-card p-6 md:p-8 rounded-3xl border border-border space-y-6">
                
                {/* Badges & Stock Bar */}
                <div className="flex flex-wrap items-center justify-between gap-3">
                  <div className="flex flex-wrap items-center gap-2">
                    <span className="text-xs font-bold uppercase tracking-wider px-3 py-1 rounded-full bg-primary/10 text-primary border border-primary/20">
                      {product.category || "Marine Equipment"}
                    </span>
                    <span className="text-xs font-bold px-3 py-1 rounded-full bg-blue-500/10 text-blue-600 dark:text-blue-400 border border-blue-500/20 flex items-center gap-1">
                      <Award size={13} />
                      {product.condition || "Brand New (OEM)"}
                    </span>
                  </div>

                  <div className="flex items-center gap-2">
                    <span className="text-xs font-semibold px-3 py-1 rounded-full bg-emerald-500/10 text-emerald-600 dark:text-emerald-400 border border-emerald-500/20 flex items-center gap-1.5">
                      <span className="w-2 h-2 rounded-full bg-emerald-500 animate-pulse" />
                      {product.inStock ? "In Stock - Ready to Ship" : "Available on Request"}
                    </span>
                  </div>
                </div>

                {/* Main Product Title */}
                <div>
                  <h1 className="text-2xl sm:text-3xl lg:text-4xl font-black tracking-tight text-foreground leading-tight">
                    {product.title}
                  </h1>
                  <div className="flex items-center gap-4 mt-2 text-xs text-muted-foreground flex-wrap">
                    <span>Part No: <strong className="text-foreground font-mono">{product.oemPartNo || "N/A"}</strong></span>
                    <span>•</span>
                    <span>Maker: <strong className="text-foreground">{product.brand || "OEM Approved"}</strong></span>
                    <span>•</span>
                    <div className="flex items-center gap-1 text-amber-500 font-bold">
                      <Star size={13} className="fill-amber-500" />
                      <span>{product.rating || 4.9}</span>
                      <span className="text-muted-foreground font-normal">(Verified Technical Score)</span>
                    </div>
                  </div>
                </div>

                {/* Main Interactive Image View */}
                <div className="relative w-full h-80 sm:h-[420px] rounded-2xl overflow-hidden bg-slate-900/5 dark:bg-slate-950/40 border border-border group flex items-center justify-center">
                  <Image 
                    src={galleryImages[selectedImageIndex]} 
                    alt={product.title}
                    fill
                    priority
                    unoptimized
                    sizes="(max-width: 768px) 100vw, 700px"
                    className="object-contain p-4 group-hover:scale-105 transition-transform duration-500"
                  />
                  
                  {/* Floating Action Buttons */}
                  <button 
                    onClick={() => setIsZoomModalOpen(true)}
                    className="absolute top-4 right-4 p-2.5 rounded-xl bg-background/80 hover:bg-background text-foreground backdrop-blur-md border border-border shadow-lg transition-all opacity-80 hover:opacity-100 cursor-pointer"
                    title="Fullscreen Preview"
                  >
                    <Maximize2 size={16} />
                  </button>

                  <div className="absolute bottom-4 left-4 px-3 py-1.5 rounded-xl bg-background/80 backdrop-blur-md border border-border text-[11px] font-bold text-foreground flex items-center gap-1.5 shadow-sm">
                    <ShieldCheck size={14} className="text-primary" />
                    <span>100% Genuine Certified Stock</span>
                  </div>
                </div>

                {/* Thumbnails Gallery Strip */}
                <div className="grid grid-cols-4 gap-3">
                  {galleryImages.map((img, idx) => (
                    <button
                      key={idx}
                      onClick={() => setSelectedImageIndex(idx)}
                      className={`relative h-20 rounded-xl overflow-hidden border-2 transition-all p-1 bg-slate-900/5 dark:bg-slate-950/30 cursor-pointer ${
                        selectedImageIndex === idx 
                          ? "border-primary ring-2 ring-primary/20 scale-[1.02]" 
                          : "border-border hover:border-primary/40 opacity-70 hover:opacity-100"
                      }`}
                    >
                      <Image 
                        src={img} 
                        alt={`Thumbnail ${idx + 1}`}
                        fill
                        unoptimized
                        className="object-cover rounded-lg"
                      />
                    </button>
                  ))}
                </div>

                {/* Key Technical Code Indicators */}
                <div className="grid grid-cols-2 sm:grid-cols-4 gap-3 bg-slate-100/70 dark:bg-slate-900/60 p-4 rounded-2xl border border-border">
                  {product.impaCode && (
                    <div>
                      <span className="text-[10px] uppercase font-bold text-muted-foreground block tracking-wider">IMPA Code</span>
                      <span className="text-sm font-black text-primary font-mono">{product.impaCode}</span>
                    </div>
                  )}
                  {product.issaCode && (
                    <div>
                      <span className="text-[10px] uppercase font-bold text-muted-foreground block tracking-wider">ISSA Code</span>
                      <span className="text-sm font-bold text-foreground font-mono">{product.issaCode}</span>
                    </div>
                  )}
                  <div>
                    <span className="text-[10px] uppercase font-bold text-muted-foreground block tracking-wider">Drawing No</span>
                    <span className="text-sm font-semibold text-foreground font-mono">{product.drawingNo || "DWG-7481"}</span>
                  </div>
                  <div>
                    <span className="text-[10px] uppercase font-bold text-muted-foreground block tracking-wider">Standard Unit</span>
                    <span className="text-sm font-semibold text-foreground">{product.unit || "Pcs / Set"}</span>
                  </div>
                </div>

              </div>

              {/* Comprehensive Tabbed Information Center */}
              <div className="glass-card rounded-3xl border border-border overflow-hidden">
                
                {/* Tab Navigation Headers */}
                <div className="flex items-center gap-2 p-2 bg-slate-100/50 dark:bg-slate-900/40 border-b border-border overflow-x-auto">
                  <button
                    onClick={() => setActiveTab("overview")}
                    className={`px-4 py-2.5 rounded-xl text-xs font-bold transition-all flex items-center gap-2 whitespace-nowrap cursor-pointer ${
                      activeTab === "overview" 
                        ? "bg-background text-primary shadow-sm border border-border" 
                        : "text-muted-foreground hover:text-foreground"
                    }`}
                  >
                    <Layers size={14} />
                    <span>Overview & Highlights</span>
                  </button>

                  <button
                    onClick={() => setActiveTab("specs")}
                    className={`px-4 py-2.5 rounded-xl text-xs font-bold transition-all flex items-center gap-2 whitespace-nowrap cursor-pointer ${
                      activeTab === "specs" 
                        ? "bg-background text-primary shadow-sm border border-border" 
                        : "text-muted-foreground hover:text-foreground"
                    }`}
                  >
                    <FileCheck2 size={14} />
                    <span>Technical Specifications</span>
                  </button>

                  <button
                    onClick={() => setActiveTab("certs")}
                    className={`px-4 py-2.5 rounded-xl text-xs font-bold transition-all flex items-center gap-2 whitespace-nowrap cursor-pointer ${
                      activeTab === "certs" 
                        ? "bg-background text-primary shadow-sm border border-border" 
                        : "text-muted-foreground hover:text-foreground"
                    }`}
                  >
                    <ShieldCheck size={14} />
                    <span>Class Approvals & Certs</span>
                  </button>

                  <button
                    onClick={() => setActiveTab("logistics")}
                    className={`px-4 py-2.5 rounded-xl text-xs font-bold transition-all flex items-center gap-2 whitespace-nowrap cursor-pointer ${
                      activeTab === "logistics" 
                        ? "bg-background text-primary shadow-sm border border-border" 
                        : "text-muted-foreground hover:text-foreground"
                    }`}
                  >
                    <Truck size={14} />
                    <span>Port Logistics</span>
                  </button>

                  <button
                    onClick={() => setActiveTab("supplier")}
                    className={`px-4 py-2.5 rounded-xl text-xs font-bold transition-all flex items-center gap-2 whitespace-nowrap cursor-pointer ${
                      activeTab === "supplier" 
                        ? "bg-background text-primary shadow-sm border border-border" 
                        : "text-muted-foreground hover:text-foreground"
                    }`}
                  >
                    <Building2 size={14} />
                    <span>Stockist Profile</span>
                  </button>
                </div>

                {/* Tab Content Display */}
                <div className="p-6 md:p-8">
                  
                  {/* TAB 1: OVERVIEW */}
                  {activeTab === "overview" && (
                    <motion.div initial={{ opacity: 0 }} animate={{ opacity: 1 }} className="space-y-6">
                      <div className="space-y-3">
                        <h3 className="text-base font-bold text-foreground flex items-center gap-2">
                          <Sparkles size={18} className="text-primary" />
                          <span>Engineering Overview & Product Description</span>
                        </h3>
                        <p className="text-sm text-muted-foreground leading-relaxed">
                          {product.description || "High-durability marine-grade industrial component manufactured according to strict SOLAS and classification society guidelines. Specifically engineered for severe maritime operating conditions, high pressure tolerance, and salt-mist corrosion resistance."}
                        </p>
                      </div>

                      <div className="grid grid-cols-1 sm:grid-cols-2 gap-4 pt-2">
                        <div className="p-4 rounded-2xl bg-card border border-border space-y-2">
                          <div className="flex items-center gap-2 text-primary font-bold text-xs">
                            <CheckCircle2 size={16} />
                            <span>Key Operational Advantages</span>
                          </div>
                          <ul className="text-xs text-muted-foreground space-y-1.5 list-disc list-inside">
                            <li>Factory calibrated and pressure tested</li>
                            <li>Direct OEM interchangeability without alteration</li>
                            <li>Enhanced cavitation & erosion resistance</li>
                            <li>Includes complete inspection certificate</li>
                          </ul>
                        </div>

                        <div className="p-4 rounded-2xl bg-card border border-border space-y-2">
                          <div className="flex items-center gap-2 text-primary font-bold text-xs">
                            <Anchor size={16} />
                            <span>Vessel & Engine Compatibility</span>
                          </div>
                          <ul className="text-xs text-muted-foreground space-y-1.5 list-disc list-inside">
                            <li>Bulk Carriers, Tankers & Container Vessels</li>
                            <li>Main Propulsion & Auxiliary Diesel Units</li>
                            <li>Emergency Generator & Purifier Systems</li>
                            <li>Compliant with MARPOL Annex VI regulations</li>
                          </ul>
                        </div>
                      </div>
                    </motion.div>
                  )}

                  {/* TAB 2: TECHNICAL SPECIFICATIONS */}
                  {activeTab === "specs" && (
                    <motion.div initial={{ opacity: 0 }} animate={{ opacity: 1 }} className="space-y-4">
                      <h3 className="text-base font-bold text-foreground">Full Technical Datasheet Parameters</h3>
                      
                      <div className="overflow-hidden rounded-2xl border border-border">
                        <table className="w-full text-xs text-left">
                          <tbody className="divide-y divide-border">
                            {product.specifications && product.specifications.length > 0 ? (
                              product.specifications.map((spec: any, idx: number) => (
                                <tr key={idx} className={idx % 2 === 0 ? "bg-slate-50/50 dark:bg-slate-900/30" : "bg-card"}>
                                  <td className="py-3 px-4 font-bold text-muted-foreground w-2/5">{spec.key}</td>
                                  <td className="py-3 px-4 text-foreground font-medium">{spec.value}</td>
                                </tr>
                              ))
                            ) : (
                              <>
                                <tr className="bg-slate-50/50 dark:bg-slate-900/30">
                                  <td className="py-3 px-4 font-bold text-muted-foreground w-2/5">Manufacturer Brand</td>
                                  <td className="py-3 px-4 text-foreground font-medium">{product.brand || "OEM Approved"}</td>
                                </tr>
                                <tr>
                                  <td className="py-3 px-4 font-bold text-muted-foreground w-2/5">Part / Drawing Reference</td>
                                  <td className="py-3 px-4 text-foreground font-mono font-medium">{product.oemPartNo || "784-0129-A"}</td>
                                </tr>
                                <tr className="bg-slate-50/50 dark:bg-slate-900/30">
                                  <td className="py-3 px-4 font-bold text-muted-foreground w-2/5">Gross Weight</td>
                                  <td className="py-3 px-4 text-foreground font-medium">{product.weight ? `${product.weight} kg` : "14.50 kg"}</td>
                                </tr>
                                <tr>
                                  <td className="py-3 px-4 font-bold text-muted-foreground w-2/5">Country of Origin</td>
                                  <td className="py-3 px-4 text-foreground font-medium">{product.origin || "Germany / Japan"}</td>
                                </tr>
                                <tr className="bg-slate-50/50 dark:bg-slate-900/30">
                                  <td className="py-3 px-4 font-bold text-muted-foreground w-2/5">Customs Tariff (GTIP / HS Code)</td>
                                  <td className="py-3 px-4 text-foreground font-mono font-medium">{product.gtip || "8409.99.00"}</td>
                                </tr>
                              </>
                            )}
                          </tbody>
                        </table>
                      </div>
                    </motion.div>
                  )}

                  {/* TAB 3: CERTIFICATES & COMPLIANCE */}
                  {activeTab === "certs" && (
                    <motion.div initial={{ opacity: 0 }} animate={{ opacity: 1 }} className="space-y-6">
                      <div className="space-y-2">
                        <h3 className="text-base font-bold text-foreground">Classification Society Approvals & Marine Certificates</h3>
                        <p className="text-xs text-muted-foreground">
                          This product complies with international maritime safety guidelines and holds official class endorsement.
                        </p>
                      </div>

                      <div className="grid grid-cols-2 sm:grid-cols-4 gap-3">
                        {["DNV", "Lloyd's Register", "ABS Class", "Bureau Veritas", "MED Wheelmark", "ClassNK"].map((cert, idx) => (
                          <div key={idx} className="p-3.5 rounded-2xl bg-card border border-border text-center space-y-1">
                            <Award size={20} className="mx-auto text-primary" />
                            <span className="text-xs font-bold text-foreground block">{cert}</span>
                            <span className="text-[10px] text-emerald-500 font-semibold block">Verified Type Approval</span>
                          </div>
                        ))}
                      </div>

                      <div className="p-4 rounded-2xl bg-primary/5 border border-primary/20 flex flex-col sm:flex-row items-center justify-between gap-4">
                        <div className="flex items-center gap-3">
                          <FileText size={24} className="text-primary flex-shrink-0" />
                          <div>
                            <h4 className="text-xs font-bold text-foreground">Mill Test Certificate (EN 10204 3.1)</h4>
                            <p className="text-[11px] text-muted-foreground">Official metallurgical and pressure test documentation PDF</p>
                          </div>
                        </div>
                        <button 
                          onClick={() => alert("Simulating Technical Datasheet PDF Download...")}
                          className="px-4 py-2 rounded-xl bg-primary text-white text-xs font-bold hover:bg-primary/90 transition-all flex items-center gap-1.5 shadow-sm cursor-pointer"
                        >
                          <Download size={14} />
                          <span>Download PDF Spec</span>
                        </button>
                      </div>
                    </motion.div>
                  )}

                  {/* TAB 4: LOGISTICS */}
                  {activeTab === "logistics" && (
                    <motion.div initial={{ opacity: 0 }} animate={{ opacity: 1 }} className="space-y-6">
                      <div className="space-y-2">
                        <h3 className="text-base font-bold text-foreground">Global Delivery Ports & Anchorage Launch Boat Hubs</h3>
                        <p className="text-xs text-muted-foreground">
                          Direct supply provided to anchorage points, shipyards, and berth terminals across major maritime corridors.
                        </p>
                      </div>

                      <div className="grid grid-cols-1 sm:grid-cols-2 gap-3">
                        {(product.deliveryPorts && product.deliveryPorts.length > 0 ? product.deliveryPorts : ["Tuzla / Istanbul", "Rotterdam", "Singapore", "Houston", "Hamburg"]).map((port: string) => {
                          const info = portLogistics[port] || { boatTime: "⚡ Direct Delivery Available", status: "Stock Hub Ready" };
                          return (
                            <div key={port} className="p-4 rounded-2xl bg-card border border-border space-y-1">
                              <div className="flex items-center justify-between">
                                <span className="text-xs font-bold text-foreground flex items-center gap-1.5">
                                  <Anchor size={14} className="text-primary" />
                                  <span>{port}</span>
                                </span>
                                <span className="text-[10px] font-semibold px-2 py-0.5 rounded-md bg-primary/10 text-primary">
                                  Active Hub
                                </span>
                              </div>
                              <p className="text-xs text-muted-foreground font-medium">{info.boatTime}</p>
                              <span className="text-[10px] text-emerald-500 font-semibold block">{info.status}</span>
                            </div>
                          );
                        })}
                      </div>
                    </motion.div>
                  )}

                  {/* TAB 5: SUPPLIER */}
                  {activeTab === "supplier" && (
                    <motion.div initial={{ opacity: 0 }} animate={{ opacity: 1 }} className="space-y-6">
                      <div className="flex items-center gap-4">
                        <div className="w-16 h-16 rounded-2xl bg-primary/10 border border-primary/20 flex items-center justify-center text-primary font-black text-2xl">
                          <Building2 size={32} />
                        </div>
                        <div>
                          <div className="flex items-center gap-2">
                            <h3 className="text-lg font-black text-foreground">{product.supplierName || "Maritime Technical Suppliers Ltd."}</h3>
                            <span className="px-2 py-0.5 rounded-full bg-blue-500/10 text-blue-500 text-[10px] font-bold border border-blue-500/20">
                              Verified Stockist
                            </span>
                          </div>
                          <p className="text-xs text-muted-foreground flex items-center gap-1 mt-0.5">
                            <MapPin size={12} className="text-primary" />
                            <span>{product.supplierLocation || "Tuzla Maritime Industrial Zone, Istanbul"}</span>
                          </p>
                        </div>
                      </div>

                      <div className="grid grid-cols-2 sm:grid-cols-4 gap-3">
                        <div className="p-3 rounded-xl bg-card border border-border">
                          <span className="text-[10px] text-muted-foreground block font-bold">RFQ Response Time</span>
                          <span className="text-xs font-black text-foreground">Under 1 Hour</span>
                        </div>
                        <div className="p-3 rounded-xl bg-card border border-border">
                          <span className="text-[10px] text-muted-foreground block font-bold">Fulfilment Rate</span>
                          <span className="text-xs font-black text-emerald-500">99.4% On-Time</span>
                        </div>
                        <div className="p-3 rounded-xl bg-card border border-border">
                          <span className="text-[10px] text-muted-foreground block font-bold">Active Inventory</span>
                          <span className="text-xs font-black text-foreground">12,500+ Items</span>
                        </div>
                        <div className="p-3 rounded-xl bg-card border border-border">
                          <span className="text-[10px] text-muted-foreground block font-bold">Quality Rating</span>
                          <span className="text-xs font-black text-amber-500">⭐ {product.rating || 4.9} / 5.0</span>
                        </div>
                      </div>
                    </motion.div>
                  )}

                </div>
              </div>

            </div>

            {/* Right Column: Buy Box, Tiered Pricing & RFQ Module (5 Cols) */}
            <div className="lg:col-span-5 space-y-6">
              
              {/* Main Buy & Action Card */}
              <div className="glass-card p-6 md:p-8 rounded-3xl border border-primary/30 shadow-2xl space-y-6 lg:sticky lg:top-28">
                
                {/* Price Display & Currency */}
                <div className="pb-4 border-b border-border space-y-2">
                  <div className="flex items-center justify-between">
                    <span className="text-[11px] uppercase font-bold text-muted-foreground tracking-wider">
                      Stockist List Price
                    </span>
                    <span className="text-[11px] font-bold text-emerald-500 bg-emerald-500/10 px-2 py-0.5 rounded-full">
                      Direct B2B Pricing
                    </span>
                  </div>

                  {product.price ? (
                    <div className="space-y-1">
                      <div className="flex items-baseline gap-2">
                        <span className="text-3xl sm:text-4xl font-black text-foreground tracking-tight">
                          {product.currency} {effectiveUnitPrice.toLocaleString("en-US", { minimumFractionDigits: 2, maximumFractionDigits: 2 })}
                        </span>
                        <span className="text-xs text-muted-foreground font-semibold">/ {product.unit || "unit"}</span>
                      </div>
                      {quantity >= 6 && (
                        <p className="text-xs text-emerald-600 dark:text-emerald-400 font-bold flex items-center gap-1">
                          <Zap size={13} />
                          <span>Bulk Tier Discount Applied ({quantity >= 20 ? "15%" : "8%"} Off)</span>
                        </p>
                      )}
                    </div>
                  ) : (
                    <div className="text-2xl sm:text-3xl font-black text-primary">
                      Price on Official Request (RFQ)
                    </div>
                  )}

                  <span className="text-[11px] text-muted-foreground block">
                    Tax Excluded • FOB / Ex-Works delivery options in quotation
                  </span>
                </div>

                {/* Tiered Bulk Pricing Table */}
                {product.price && (
                  <div className="space-y-2">
                    <span className="text-xs font-bold text-foreground block">Volume Tiered Discounts</span>
                    <div className="grid grid-cols-3 gap-2 text-center text-xs">
                      <div className={`p-2.5 rounded-xl border transition-all ${quantity < 6 ? "bg-primary/10 border-primary/40 font-bold text-primary" : "bg-card border-border text-muted-foreground"}`}>
                        <span className="block text-[10px] uppercase font-bold">1 - 5 Pcs</span>
                        <span>{product.currency} {unitPrice.toFixed(2)}</span>
                      </div>
                      <div className={`p-2.5 rounded-xl border transition-all ${quantity >= 6 && quantity < 20 ? "bg-primary/10 border-primary/40 font-bold text-primary" : "bg-card border-border text-muted-foreground"}`}>
                        <span className="block text-[10px] uppercase font-bold">6 - 19 Pcs</span>
                        <span>{product.currency} {(unitPrice * 0.92).toFixed(2)}</span>
                      </div>
                      <div className={`p-2.5 rounded-xl border transition-all ${quantity >= 20 ? "bg-primary/10 border-primary/40 font-bold text-primary" : "bg-card border-border text-muted-foreground"}`}>
                        <span className="block text-[10px] uppercase font-bold">20+ Fleet</span>
                        <span>{product.currency} {(unitPrice * 0.85).toFixed(2)}</span>
                      </div>
                    </div>
                  </div>
                )}

                {/* Quantity Selector & Subtotal */}
                <div className="space-y-3">
                  <div className="flex items-center justify-between">
                    <span className="text-xs font-bold text-foreground">Order Quantity</span>
                    {product.price && (
                      <span className="text-xs text-muted-foreground">
                        Est. Total: <strong className="text-foreground font-black">{product.currency} {subtotal.toLocaleString("en-US", { minimumFractionDigits: 2 })}</strong>
                      </span>
                    )}
                  </div>

                  <div className="flex items-center gap-3">
                    <div className="flex items-center rounded-2xl bg-slate-100 dark:bg-slate-800 border border-border p-1">
                      <button
                        onClick={() => setQuantity(Math.max(1, quantity - 1))}
                        className="w-9 h-9 rounded-xl flex items-center justify-center text-foreground hover:bg-background transition-all cursor-pointer"
                      >
                        <Minus size={15} />
                      </button>
                      <input
                        type="number"
                        min="1"
                        value={quantity}
                        onChange={(e) => setQuantity(Math.max(1, parseInt(e.target.value) || 1))}
                        className="w-14 text-center bg-transparent font-bold text-sm text-foreground outline-none"
                      />
                      <button
                        onClick={() => setQuantity(quantity + 1)}
                        className="w-9 h-9 rounded-xl flex items-center justify-center text-foreground hover:bg-background transition-all cursor-pointer"
                      >
                        <Plus size={15} />
                      </button>
                    </div>

                    <button
                      onClick={handleAddToCart}
                      className="flex-1 py-3.5 px-4 rounded-2xl bg-slate-100 dark:bg-slate-800 hover:bg-slate-200 dark:hover:bg-slate-700 text-foreground font-bold text-xs border border-border transition-all flex items-center justify-center gap-2 cursor-pointer shadow-sm active:scale-95"
                    >
                      <ShoppingCart size={16} className="text-primary" />
                      <span>Add to RFQ Cart</span>
                    </button>
                  </div>
                </div>

                {/* Action Buttons: RFQ & Direct WhatsApp */}
                <div className="space-y-3 pt-2">
                  <button
                    onClick={() => setIsRfqModalOpen(true)}
                    className="w-full py-4 rounded-2xl bg-gradient-to-r from-primary via-blue-600 to-sky-600 hover:from-primary/95 hover:to-sky-600/95 text-white font-black text-sm transition-all shadow-xl shadow-primary/25 flex items-center justify-center gap-2 hover:scale-[1.02] active:scale-[0.98] cursor-pointer"
                  >
                    <Send size={18} />
                    <span>Request Official Quotation (RFQ)</span>
                  </button>

                  <a
                    href="https://wa.me/905320000000?text=Hello,%20I%20am%20inquiring%20about%20item%20IMPA%20Code:%20"
                    target="_blank"
                    rel="noreferrer"
                    className="w-full py-3.5 rounded-2xl bg-emerald-500/10 hover:bg-emerald-500/20 text-emerald-600 dark:text-emerald-400 font-bold text-xs border border-emerald-500/20 transition-all flex items-center justify-center gap-2"
                  >
                    <Phone size={15} />
                    <span>Direct WhatsApp Technical Desk (+90 532 000 0000)</span>
                  </a>

                  <p className="text-[11px] text-center text-muted-foreground flex items-center justify-center gap-1.5 pt-1">
                    <Clock size={13} className="text-primary" />
                    <span>Guaranteed official quote within 60 minutes for vessel orders</span>
                  </p>
                </div>

                {/* Delivery Hub Estimator Box */}
                <div className="p-4 rounded-2xl bg-slate-50 dark:bg-slate-900/60 border border-border space-y-3">
                  <div className="flex items-center justify-between">
                    <span className="text-xs font-bold text-foreground flex items-center gap-1.5">
                      <Truck size={14} className="text-primary" />
                      <span>Delivery Port Estimator</span>
                    </span>
                    <span className="text-[10px] text-primary font-semibold">Live Transit</span>
                  </div>

                  <select
                    value={selectedPort}
                    onChange={(e) => setSelectedPort(e.target.value)}
                    className="w-full px-3 py-2 rounded-xl bg-background border border-border text-xs text-foreground font-semibold outline-none focus:border-primary"
                  >
                    {["Tuzla / Istanbul", "Rotterdam", "Singapore", "Hamburg", "Houston", "Dubai", "Piraeus", "Yalova"].map(port => (
                      <option key={port} value={port}>{port}</option>
                    ))}
                  </select>

                  <div className="text-xs space-y-1 pt-1">
                    <div className="flex items-center justify-between text-muted-foreground">
                      <span>Dispatch Method:</span>
                      <strong className="text-foreground">{portLogistics[selectedPort]?.boatTime || "⚡ Launch Boat: 2-4 Hours"}</strong>
                    </div>
                    <div className="flex items-center justify-between text-muted-foreground">
                      <span>Customs Clearance:</span>
                      <strong className="text-emerald-500 font-semibold">Transit Permit Included</strong>
                    </div>
                  </div>
                </div>

                {/* Buyer Protection Badges */}
                <div className="pt-2 border-t border-border grid grid-cols-2 gap-3 text-[11px] text-muted-foreground">
                  <div className="flex items-center gap-2">
                    <ShieldCheck size={16} className="text-primary flex-shrink-0" />
                    <span>30-Day Technical Fit Guarantee</span>
                  </div>
                  <div className="flex items-center gap-2">
                    <Award size={16} className="text-primary flex-shrink-0" />
                    <span>Original Class Certificate</span>
                  </div>
                </div>

              </div>

            </div>

          </div>

          {/* Related / Frequently Bought Together Marine Parts */}
          {relatedProducts.length > 0 && (
            <div className="mt-16 space-y-6">
              <div className="flex items-center justify-between">
                <div>
                  <h2 className="text-xl sm:text-2xl font-black text-foreground">Frequently Sourced Together</h2>
                  <p className="text-xs text-muted-foreground">Compatible components and alternative stock available in nearest maritime hubs</p>
                </div>
                <Link 
                  href="/listings"
                  className="text-xs font-bold text-primary hover:underline flex items-center gap-1"
                >
                  <span>Browse All Stock</span>
                  <ChevronRight size={14} />
                </Link>
              </div>

              <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-6">
                {relatedProducts.map((rel) => (
                  <Link 
                    key={rel.id} 
                    href={`/listings/${rel.id}`}
                    className="glass-card rounded-2xl border border-border p-4 hover:border-primary/50 transition-all hover:scale-[1.02] space-y-3 group block"
                  >
                    <div className="relative w-full h-40 rounded-xl overflow-hidden bg-slate-900/10 dark:bg-slate-950/40">
                      <Image 
                        src={rel.image || "/images/hero-bg.jpg"} 
                        alt={rel.title}
                        fill
                        unoptimized
                        className="object-cover group-hover:scale-105 transition-transform"
                      />
                      {rel.impaCode && (
                        <span className="absolute top-2 left-2 px-2 py-0.5 rounded-md bg-black/70 backdrop-blur-md text-[10px] font-mono font-bold text-white">
                          IMPA {rel.impaCode}
                        </span>
                      )}
                    </div>

                    <div className="space-y-1">
                      <span className="text-[10px] uppercase font-bold text-primary">{rel.category || "Marine Equipment"}</span>
                      <h4 className="text-xs font-bold text-foreground line-clamp-2 leading-tight group-hover:text-primary transition-colors">
                        {rel.title}
                      </h4>
                    </div>

                    <div className="pt-2 border-t border-border flex items-center justify-between text-xs">
                      <span className="font-black text-foreground">
                        {rel.price ? `${rel.currency} ${rel.price.toLocaleString("en-US", { minimumFractionDigits: 2 })}` : "Price on RFQ"}
                      </span>
                      <span className="text-[10px] text-primary font-bold">View Specs →</span>
                    </div>
                  </Link>
                ))}
              </div>
            </div>
          )}

        </div>

        {/* Sticky Bottom Action Bar (Desktop & Mobile) */}
        <AnimatePresence>
          {showStickyBar && (
            <motion.div
              initial={{ y: 100, opacity: 0 }}
              animate={{ y: 0, opacity: 1 }}
              exit={{ y: 100, opacity: 0 }}
              className="fixed bottom-0 left-0 right-0 z-40 bg-background/95 backdrop-blur-xl border-t border-border shadow-2xl py-3 px-6"
            >
              <div className="container mx-auto flex items-center justify-between gap-4">
                <div className="flex items-center gap-3 min-w-0">
                  <div className="relative w-12 h-12 rounded-xl overflow-hidden bg-slate-900/10 flex-shrink-0 hidden sm:block">
                    <Image 
                      src={galleryImages[0]} 
                      alt={product.title} 
                      fill 
                      unoptimized
                      className="object-cover" 
                    />
                  </div>
                  <div className="min-w-0">
                    <h4 className="text-xs font-bold text-foreground truncate max-w-sm">{product.title}</h4>
                    <div className="flex items-center gap-2 text-[11px] text-muted-foreground">
                      {product.price ? (
                        <span className="font-black text-foreground">{product.currency} {effectiveUnitPrice.toFixed(2)}</span>
                      ) : (
                        <span className="font-bold text-primary">Price on RFQ</span>
                      )}
                      <span>•</span>
                      <span>Delivery to: {selectedPort}</span>
                    </div>
                  </div>
                </div>

                <div className="flex items-center gap-2">
                  <button
                    onClick={() => setQuantity(Math.max(1, quantity - 1))}
                    className="w-8 h-8 rounded-lg bg-slate-100 dark:bg-slate-800 text-foreground hidden sm:flex items-center justify-center font-bold text-xs cursor-pointer"
                  >
                    -
                  </button>
                  <span className="text-xs font-bold px-2 hidden sm:inline">{quantity}</span>
                  <button
                    onClick={() => setQuantity(quantity + 1)}
                    className="w-8 h-8 rounded-lg bg-slate-100 dark:bg-slate-800 text-foreground hidden sm:flex items-center justify-center font-bold text-xs cursor-pointer"
                  >
                    +
                  </button>

                  <button
                    onClick={handleAddToCart}
                    className="px-4 py-2.5 rounded-xl bg-slate-100 dark:bg-slate-800 text-foreground font-bold text-xs border border-border hover:bg-slate-200 hidden sm:flex items-center gap-1.5 cursor-pointer"
                  >
                    <ShoppingCart size={14} />
                    <span>Add to Cart</span>
                  </button>

                  <button
                    onClick={() => setIsRfqModalOpen(true)}
                    className="px-5 py-2.5 rounded-xl bg-primary hover:bg-primary/90 text-white font-bold text-xs shadow-lg shadow-primary/25 flex items-center gap-2 cursor-pointer"
                  >
                    <Send size={14} />
                    <span>Submit RFQ</span>
                  </button>
                </div>
              </div>
            </motion.div>
          )}
        </AnimatePresence>

        {/* Fullscreen Image Zoom Modal */}
        <AnimatePresence>
          {isZoomModalOpen && (
            <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-black/85 backdrop-blur-md">
              <button 
                onClick={() => setIsZoomModalOpen(false)}
                className="absolute top-6 right-6 p-3 rounded-full bg-white/10 hover:bg-white/20 text-white transition-all cursor-pointer"
              >
                <X size={24} />
              </button>
              <div className="relative w-full max-w-4xl h-[80vh]">
                <Image 
                  src={galleryImages[selectedImageIndex]} 
                  alt={product.title} 
                  fill 
                  unoptimized
                  className="object-contain" 
                />
              </div>
            </div>
          )}
        </AnimatePresence>

        {/* B2B Official Quotation (RFQ) Modal */}
        <AnimatePresence>
          {isRfqModalOpen && (
            <div className="fixed inset-0 z-50 flex items-center justify-center p-4">
              <motion.div
                initial={{ opacity: 0 }}
                animate={{ opacity: 1 }}
                exit={{ opacity: 0 }}
                onClick={() => setIsRfqModalOpen(false)}
                className="absolute inset-0 bg-black/60 backdrop-blur-sm"
              />

              <motion.div
                initial={{ opacity: 0, scale: 0.95, y: 20 }}
                animate={{ opacity: 1, scale: 1, y: 0 }}
                exit={{ opacity: 0, scale: 0.95, y: 20 }}
                className="relative w-full max-w-xl glass-card bg-background/95 rounded-3xl p-6 md:p-8 border border-border shadow-2xl z-10 space-y-6 max-h-[90vh] overflow-y-auto"
              >
                
                {/* Modal Header */}
                <div className="flex items-center justify-between pb-4 border-b border-border">
                  <div>
                    <h3 className="text-xl font-black text-foreground flex items-center gap-2">
                      <Send size={18} className="text-primary" />
                      <span>Request Official Quotation (RFQ)</span>
                    </h3>
                    <p className="text-xs text-muted-foreground mt-0.5">
                      Technical RFQ dispatched to {product.supplierName || "Verified Stockist"}
                    </p>
                  </div>
                  <button
                    onClick={() => setIsRfqModalOpen(false)}
                    className="p-2 rounded-xl text-muted-foreground hover:text-foreground hover:bg-slate-100 dark:hover:bg-slate-800 transition-colors cursor-pointer"
                  >
                    <X size={18} />
                  </button>
                </div>

                {rfqSubmitted ? (
                  <div className="py-12 text-center space-y-4">
                    <div className="w-16 h-16 rounded-full bg-green-500/10 border border-green-500/20 text-green-500 flex items-center justify-center mx-auto">
                      <CheckCircle2 size={32} />
                    </div>
                    <h4 className="text-xl font-bold text-foreground">RFQ Transmitted Successfully!</h4>
                    <p className="text-xs text-muted-foreground max-w-sm mx-auto">
                      Your technical quotation request for <strong>{product.title}</strong> has been logged. Stockist will return with FOB / CIF quote in under 1 hour.
                    </p>
                  </div>
                ) : (
                  <form onSubmit={handleRfqSubmit} className="space-y-4">
                    <div className="p-3 rounded-2xl bg-primary/5 border border-primary/20 flex items-center gap-3">
                      <div className="relative w-12 h-12 rounded-xl overflow-hidden bg-slate-900/10 flex-shrink-0">
                        <Image src={galleryImages[0]} alt={product.title} fill unoptimized className="object-cover" />
                      </div>
                      <div className="text-xs">
                        <span className="font-bold text-foreground block truncate max-w-xs">{product.title}</span>
                        <span className="text-muted-foreground">IMPA: {product.impaCode || "N/A"} • OEM Part: {product.oemPartNo || "Standard"}</span>
                      </div>
                    </div>

                    <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
                      <div>
                        <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-1.5 block">
                          Vessel Name (Gemi Adı) *
                        </label>
                        <input
                          type="text"
                          required
                          value={rfqForm.vesselName}
                          onChange={(e) => setRfqForm({ ...rfqForm, vesselName: e.target.value })}
                          placeholder="e.g. M/V BLUE WAVE"
                          className="w-full px-3.5 py-2.5 rounded-xl bg-background border border-border focus:border-primary outline-none text-xs text-foreground"
                        />
                      </div>

                      <div>
                        <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-1.5 block">
                          IMO Number *
                        </label>
                        <input
                          type="text"
                          required
                          value={rfqForm.imoNumber}
                          onChange={(e) => setRfqForm({ ...rfqForm, imoNumber: e.target.value })}
                          placeholder="e.g. 9845210"
                          className="w-full px-3.5 py-2.5 rounded-xl bg-background border border-border focus:border-primary outline-none text-xs text-foreground"
                        />
                      </div>
                    </div>

                    <div className="grid grid-cols-1 md:grid-cols-3 gap-4">
                      <div className="md:col-span-2">
                        <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-1.5 block">
                          Port of Delivery (Teslim Limanı) *
                        </label>
                        <input
                          type="text"
                          required
                          value={rfqForm.portOfDelivery}
                          onChange={(e) => setRfqForm({ ...rfqForm, portOfDelivery: e.target.value })}
                          placeholder="e.g. Tuzla, Rotterdam, Singapore..."
                          className="w-full px-3.5 py-2.5 rounded-xl bg-background border border-border focus:border-primary outline-none text-xs text-foreground"
                        />
                      </div>

                      <div>
                        <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-1.5 block">
                          Quantity ({product.unit || "Adet"}) *
                        </label>
                        <input
                          type="number"
                          min="1"
                          required
                          value={rfqForm.quantity}
                          onChange={(e) => setRfqForm({ ...rfqForm, quantity: e.target.value })}
                          className="w-full px-3.5 py-2.5 rounded-xl bg-background border border-border focus:border-primary outline-none text-xs text-foreground"
                        />
                      </div>
                    </div>

                    <div>
                      <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-1.5 block">
                        Estimated Date of Arrival (ETA)
                      </label>
                      <input
                        type="date"
                        value={rfqForm.etaDate}
                        onChange={(e) => setRfqForm({ ...rfqForm, etaDate: e.target.value })}
                        className="w-full px-3.5 py-2.5 rounded-xl bg-background border border-border focus:border-primary outline-none text-xs text-foreground"
                      />
                    </div>

                    <div>
                      <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-1.5 block">
                        Technical Notes / Certificate Demands (DNV, MED, MTC 3.1)
                      </label>
                      <textarea
                        rows={3}
                        value={rfqForm.notes}
                        onChange={(e) => setRfqForm({ ...rfqForm, notes: e.target.value })}
                        placeholder="Specify maker serials, drawing positions, or urgent launch boat dispatch requirements..."
                        className="w-full px-3.5 py-2.5 rounded-xl bg-background border border-border focus:border-primary outline-none text-xs text-foreground resize-none"
                      />
                    </div>

                    <button
                      type="submit"
                      disabled={isSubmitting}
                      className="w-full py-3.5 rounded-xl bg-primary hover:bg-primary/90 text-white font-bold text-xs transition-colors shadow-lg shadow-primary/25 flex items-center justify-center gap-2 cursor-pointer disabled:opacity-50"
                    >
                      {isSubmitting ? (
                        <>
                          <Loader2 size={16} className="animate-spin" />
                          <span>Transmitting to Marine Network...</span>
                        </>
                      ) : (
                        <>
                          <Send size={16} />
                          <span>Submit Official RFQ to Stockist</span>
                        </>
                      )}
                    </button>
                  </form>
                )}

              </motion.div>
            </div>
          )}
        </AnimatePresence>

      </main>
    </>
  );
}
