"use client";

import React, { useState, useEffect, use } from "react";
import { Navbar } from "@/components/navbar";
import { 
  ShieldCheck, MapPin, Building2, Anchor, Mail, Share2, 
  Heart, ExternalLink, MessageSquare, CheckCircle2, Clock, 
  Globe2, FileCheck2, AlertCircle, X, Send, Award, Layers,
  Loader2, PackageSearch, ArrowLeft
} from "lucide-react";
import { motion, AnimatePresence } from "framer-motion";
import Image from "next/image";
import Link from "next/link";
import { apiClient, ApiProduct } from "@/lib/api";

export default function ListingDetailPage({ params }: { params: Promise<{ id: string }> }) {
  const resolvedParams = use(params);
  const id = resolvedParams.id;

  const [product, setProduct] = useState<any>(null);
  const [isLoading, setIsLoading] = useState(true);
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

  useEffect(() => {
    async function loadProduct() {
      setIsLoading(true);
      const res = await apiClient.getProductById(id);
      if (res) {
        setProduct(res);
      } else {
        setProduct(null);
      }
      setIsLoading(false);
    }
    loadProduct();
  }, [id]);

  const handleRfqSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setIsSubmitting(true);
    
    await apiClient.submitRfq({
      productId: parseInt(id) || undefined,
      vesselName: rfqForm.vesselName,
      imoNumber: rfqForm.imoNumber,
      portOfDelivery: rfqForm.portOfDelivery,
      etaDate: rfqForm.etaDate || undefined,
      quantity: parseFloat(rfqForm.quantity) || 1,
      notes: rfqForm.notes
    });

    setIsSubmitting(false);
    setRfqSubmitted(true);
    setTimeout(() => {
      setIsRfqModalOpen(false);
      setRfqSubmitted(false);
    }, 2500);
  };

  if (isLoading) {
    return (
      <>
        <Navbar />
        <main className="min-h-screen bg-background pt-32 pb-20">
          <div className="container mx-auto px-6 max-w-5xl space-y-8 animate-pulse">
            <div className="h-6 bg-slate-200 dark:bg-slate-800 rounded-full w-48" />
            <div className="grid grid-cols-1 lg:grid-cols-3 gap-8">
              <div className="lg:col-span-2 space-y-6">
                <div className="h-80 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
                <div className="h-40 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
              </div>
              <div className="space-y-6">
                <div className="h-72 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
                <div className="h-48 bg-slate-200 dark:bg-slate-800 rounded-3xl" />
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
      <main className="min-h-screen bg-background pt-24 pb-20">
        
        {/* Breadcrumb Bar */}
        <div className="container mx-auto px-6 mb-6">
          <div className="text-xs text-muted-foreground flex items-center gap-2 flex-wrap">
            <Link href="/" className="hover:text-primary transition-colors">Home</Link>
            <span>/</span>
            <Link href="/listings" className="hover:text-primary transition-colors">Listings</Link>
            <span>/</span>
            <span className="text-foreground font-semibold truncate max-w-sm">{product.title}</span>
          </div>
        </div>

        <div className="container mx-auto px-6">
          <div className="flex flex-col lg:flex-row gap-8">
            
            {/* Left Content (Gallery & Specs) */}
            <div className="flex-1 space-y-8">
              
              {/* Product Header & Main Card */}
              <div className="glass-card p-6 md:p-8 rounded-3xl border border-border space-y-6">
                
                {/* Category & Verified Badge */}
                <div className="flex flex-wrap items-center justify-between gap-2">
                  <span className="text-xs font-bold uppercase tracking-wider px-3 py-1 rounded-full bg-primary/10 text-primary border border-primary/20">
                    {product.category || "Marine Equipment"}
                  </span>
                  <div className="flex items-center gap-2">
                    <span className="text-xs font-semibold px-3 py-1 rounded-full bg-green-500/10 text-green-600 dark:text-green-400 border border-green-500/20 flex items-center gap-1">
                      <CheckCircle2 size={12} />
                      {product.inStock ? "In Stock" : "On Request"}
                    </span>
                    <span className="text-xs font-semibold px-3 py-1 rounded-full bg-blue-500/10 text-blue-600 dark:text-blue-400 border border-blue-500/20 flex items-center gap-1">
                      <ShieldCheck size={12} />
                      Verified Stock
                    </span>
                  </div>
                </div>

                {/* Title */}
                <h1 className="text-2xl md:text-3xl font-black tracking-tight text-foreground">
                  {product.title}
                </h1>

                {/* Key Technical Codes Bar */}
                <div className="grid grid-cols-2 sm:grid-cols-4 gap-3 bg-slate-100/70 dark:bg-slate-900/60 p-4 rounded-2xl border border-border">
                  {product.impaCode && (
                    <div>
                      <span className="text-[11px] uppercase font-bold text-muted-foreground block">IMPA Code</span>
                      <span className="text-sm font-extrabold text-primary">{product.impaCode}</span>
                    </div>
                  )}
                  {product.issaCode && (
                    <div>
                      <span className="text-[11px] uppercase font-bold text-muted-foreground block">ISSA Code</span>
                      <span className="text-sm font-semibold text-foreground">{product.issaCode}</span>
                    </div>
                  )}
                  {product.oemPartNo && (
                    <div>
                      <span className="text-[11px] uppercase font-bold text-muted-foreground block">Part / Spec No</span>
                      <span className="text-sm font-semibold text-foreground font-mono">{product.oemPartNo}</span>
                    </div>
                  )}
                  <div>
                    <span className="text-[11px] uppercase font-bold text-muted-foreground block">Brand / Maker</span>
                    <span className="text-sm font-semibold text-foreground">{product.brand || "OEM"}</span>
                  </div>
                </div>

                {/* Product Image */}
                <div className="relative w-full h-80 md:h-96 rounded-2xl overflow-hidden bg-slate-950/20 border border-border flex items-center justify-center">
                  <Image 
                    src={product.image || "/images/hero-bg.jpg"} 
                    alt={product.title}
                    fill
                    sizes="(max-width: 768px) 100vw, 800px"
                    className="object-cover object-center hover:scale-105 transition-transform duration-700"
                  />
                  <div className="absolute top-4 left-4 px-3 py-1.5 rounded-xl glass-nav text-xs font-bold text-foreground flex items-center gap-1.5">
                    <Award size={14} className="text-primary" />
                    <span>{product.condition || "Brand New (OEM)"}</span>
                  </div>
                </div>

                {/* Description */}
                <div className="space-y-3 pt-2">
                  <h3 className="text-base font-bold text-foreground flex items-center gap-2">
                    <Layers size={18} className="text-primary" />
                    <span>Product Overview & Description</span>
                  </h3>
                  <p className="text-sm text-muted-foreground leading-relaxed">
                    {product.description}
                  </p>
                </div>

              </div>

              {/* Technical Specifications Table */}
              <div className="glass-card p-6 md:p-8 rounded-3xl border border-border space-y-6">
                <h3 className="text-lg font-bold text-foreground flex items-center gap-2">
                  <FileCheck2 size={20} className="text-primary" />
                  <span>Technical Specifications & Class Compliance</span>
                </h3>

                <div className="overflow-hidden rounded-2xl border border-border">
                  <table className="w-full text-xs text-left">
                    <tbody className="divide-y divide-border">
                      {product.specifications && product.specifications.length > 0 ? (
                        product.specifications.map((spec: any, idx: number) => (
                          <tr key={idx} className={idx % 2 === 0 ? "bg-slate-50/50 dark:bg-slate-900/30" : ""}>
                            <td className="py-3 px-4 font-bold text-muted-foreground w-1/3">{spec.key}</td>
                            <td className="py-3 px-4 text-foreground font-medium">{spec.value}</td>
                          </tr>
                        ))
                      ) : (
                        <tr>
                          <td className="py-3 px-4 font-bold text-muted-foreground w-1/3">Standard Unit</td>
                          <td className="py-3 px-4 text-foreground font-medium">{product.unit || "Pcs"}</td>
                        </tr>
                      )}
                    </tbody>
                  </table>
                </div>
              </div>

              {/* Delivery Ports */}
              <div className="glass-card p-6 md:p-8 rounded-3xl border border-border space-y-4">
                <h3 className="text-lg font-bold text-foreground flex items-center gap-2">
                  <MapPin size={20} className="text-primary" />
                  <span>Available Delivery Ports & Supply Hubs</span>
                </h3>
                <p className="text-xs text-muted-foreground">
                  This supplier provides rapid launch boat, anchorage, and shipyard delivery across the following key maritime hubs:
                </p>
                <div className="flex flex-wrap gap-2 pt-1">
                  {product.deliveryPorts && product.deliveryPorts.map((port: string) => (
                    <span 
                      key={port} 
                      className="px-3.5 py-1.5 rounded-xl bg-slate-100 dark:bg-slate-800 text-xs font-semibold text-foreground border border-border flex items-center gap-1.5"
                    >
                      <Anchor size={12} className="text-primary" />
                      <span>{port}</span>
                    </span>
                  ))}
                </div>
              </div>

            </div>

            {/* Right Sidebar (Pricing & B2B RFQ Action) */}
            <div className="w-full lg:w-96 space-y-6 flex-shrink-0">
              
              {/* Price & Action Card */}
              <div className="glass-card p-6 rounded-3xl border border-primary/30 shadow-xl space-y-6 sticky top-28">
                
                {/* Price Display */}
                <div>
                  <span className="text-xs uppercase font-bold text-muted-foreground block mb-1">
                    Direct Stockist Price
                  </span>
                  {product.price ? (
                    <div className="flex items-baseline gap-2">
                      <span className="text-3xl font-black text-foreground">
                        {product.currency} {product.price.toLocaleString("en-US", { minimumFractionDigits: 2 })}
                      </span>
                      <span className="text-xs text-muted-foreground">/ {product.unit || "unit"}</span>
                    </div>
                  ) : (
                    <div className="text-2xl font-black text-primary">
                      Price on Request (RFQ)
                    </div>
                  )}
                  <span className="text-[11px] text-muted-foreground mt-1 block">
                    Ex-Works / FOB Port options available in quotation
                  </span>
                </div>

                {/* RFQ Trigger Button */}
                <div className="space-y-3 pt-2">
                  <button
                    onClick={() => setIsRfqModalOpen(true)}
                    className="w-full py-4 rounded-2xl bg-gradient-to-r from-primary to-blue-600 hover:from-primary/90 hover:to-blue-600/90 text-white font-bold text-sm transition-all shadow-lg shadow-primary/25 flex items-center justify-center gap-2 hover:scale-[1.02] active:scale-[0.98]"
                  >
                    <Send size={16} />
                    <span>Request Official Quotation (RFQ)</span>
                  </button>

                  <p className="text-[11px] text-center text-muted-foreground">
                    ⚡ Guaranteed response within 1 hour for urgent vessel orders
                  </p>
                </div>

                {/* Supplier Profile Widget */}
                <div className="pt-6 border-t border-border space-y-4">
                  <span className="text-xs uppercase font-bold text-muted-foreground block">
                    Verified Stockist
                  </span>
                  
                  <div className="flex items-center gap-3">
                    <div className="w-12 h-12 rounded-2xl bg-primary/10 border border-primary/20 flex items-center justify-center text-primary font-black text-lg">
                      <Building2 size={24} />
                    </div>
                    <div>
                      <h4 className="font-bold text-sm text-foreground">{product.supplierName}</h4>
                      <p className="text-xs text-muted-foreground flex items-center gap-1 mt-0.5">
                        <MapPin size={11} className="text-primary" />
                        <span>{product.supplierLocation}</span>
                      </p>
                    </div>
                  </div>

                  <div className="grid grid-cols-2 gap-2 text-xs pt-1">
                    <div className="p-2.5 rounded-xl bg-background/50 border border-border">
                      <span className="text-[10px] text-muted-foreground block font-semibold">Response Time</span>
                      <span className="font-bold text-foreground">Under 1 hour</span>
                    </div>
                    <div className="p-2.5 rounded-xl bg-background/50 border border-border">
                      <span className="text-[10px] text-muted-foreground block font-semibold">Quality Rating</span>
                      <span className="font-bold text-foreground">⭐ {product.rating || 4.9} / 5.0</span>
                    </div>
                  </div>
                </div>

              </div>

            </div>

          </div>
        </div>

        {/* B2B RFQ MODAL */}
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
                className="relative w-full max-w-xl glass-card bg-background/95 rounded-3xl p-6 md:p-8 border border-border shadow-2xl z-10 space-y-6"
              >
                
                {/* Modal Header */}
                <div className="flex items-center justify-between pb-4 border-b border-border">
                  <div>
                    <h3 className="text-xl font-black text-foreground flex items-center gap-2">
                      <Send size={18} className="text-primary" />
                      <span>Request Official Quote (RFQ)</span>
                    </h3>
                    <p className="text-xs text-muted-foreground mt-0.5">
                      Direct inquiry to {product.supplierName}
                    </p>
                  </div>
                  <button
                    onClick={() => setIsRfqModalOpen(false)}
                    className="p-2 rounded-xl text-muted-foreground hover:text-foreground hover:bg-slate-100 dark:hover:bg-slate-800 transition-colors"
                  >
                    <X size={18} />
                  </button>
                </div>

                {rfqSubmitted ? (
                  <div className="py-12 text-center space-y-4">
                    <div className="w-16 h-16 rounded-full bg-green-500/10 border border-green-500/20 text-green-500 flex items-center justify-center mx-auto">
                      <CheckCircle2 size={32} />
                    </div>
                    <h4 className="text-xl font-bold text-foreground">RFQ Submitted Successfully!</h4>
                    <p className="text-xs text-muted-foreground max-w-sm mx-auto">
                      Your technical quotation request has been recorded into the system and dispatched directly to the stockist.
                    </p>
                  </div>
                ) : (
                  <form onSubmit={handleRfqSubmit} className="space-y-4">
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
                          placeholder="e.g. M/V BLUE STAR"
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
                          Quantity (Adet) *
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
                        Technical Notes / Urgent Requirements
                      </label>
                      <textarea
                        rows={3}
                        value={rfqForm.notes}
                        onChange={(e) => setRfqForm({ ...rfqForm, notes: e.target.value })}
                        placeholder="Specify drawing numbers, maker serials, or certificate demands (DNV / MED)..."
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
                          <span>Transmitting to Database...</span>
                        </>
                      ) : (
                        <>
                          <Send size={16} />
                          <span>Submit Official Quotation Request (RFQ)</span>
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
