"use client";

import React, { useState, useMemo, useEffect } from "react";
import { Navbar } from "@/components/navbar";
import { ProductCard, ProductListing } from "@/components/product-card";
import { 
  Search, Filter, SlidersHorizontal, ChevronDown, 
  MapPin, Anchor, ShieldCheck, CheckCircle2, RotateCcw,
  Sparkles, Award, Ship, Loader2, PackageSearch,
  ChevronLeft, ChevronRight, ChevronsLeft, ChevronsRight
} from "lucide-react";
import { motion } from "framer-motion";
import { apiClient, ApiProduct } from "@/lib/api";

export interface RichProductListing extends ProductListing {
  condition: "Brand New (OEM)" | "New (Aftermarket)" | "Reconditioned" | "Used";
  classApproval?: string[];
  portOfDelivery: string[];
  oemPartNo?: string;
  inStock: boolean;
  brand: string;
}

const PORTS = ["All Ports", "Tuzla", "Rotterdam", "Singapore", "Hamburg", "Houston", "Dubai", "Piraeus", "Busan", "Istanbul", "Izmir", "Aliaga", "Yalova"];
const CONDITIONS = ["All Conditions", "Brand New (OEM)", "New (Aftermarket)", "Reconditioned", "Used"];
const CLASS_APPROVALS = ["DNV", "MED Wheelmark", "ABS", "Bureau Veritas", "Lloyd's Register", "ClassNK", "SOLAS"];

export default function ListingsPage() {
  const [products, setProducts] = useState<RichProductListing[]>([]);
  const [totalCount, setTotalCount] = useState(0);
  const [currentPage, setCurrentPage] = useState(1);
  const [pageSize] = useState(24);
  const [isLoading, setIsLoading] = useState(true);
  
  // Filters
  const [searchQuery, setSearchQuery] = useState("");
  const [selectedPort, setSelectedPort] = useState("All Ports");
  const [selectedCondition, setSelectedCondition] = useState("All Conditions");
  const [selectedClass, setSelectedClass] = useState<string[]>([]);
  const [verifiedOnly, setVerifiedOnly] = useState(false);
  const [inStockOnly, setInStockOnly] = useState(false);
  const [sortBy, setSortBy] = useState<"featured" | "price-asc" | "price-desc">("featured");

  const totalPages = Math.max(1, Math.ceil(totalCount / pageSize));

  // Reset to page 1 whenever filters change
  const handleFilterChange = (setter: () => void) => {
    setCurrentPage(1);
    setter();
  };

  // Fetch live products directly from database API with 24 pagination
  useEffect(() => {
    let isMounted = true;
    async function loadDatabaseProducts() {
      setIsLoading(true);
      const res = await apiClient.getProducts({
        search: searchQuery || undefined,
        port: selectedPort !== "All Ports" ? selectedPort : undefined,
        condition: selectedCondition !== "All Conditions" ? selectedCondition : undefined,
        verifiedOnly: verifiedOnly || undefined,
        pageNumber: currentPage,
        pageSize: pageSize
      });

      if (!isMounted) return;

      if (res && res.items) {
        const mapped: RichProductListing[] = res.items.map(item => ({
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
          portOfDelivery: item.deliveryPorts && item.deliveryPorts.length > 0 ? item.deliveryPorts : ["Tuzla", "Rotterdam", "Singapore"],
          isVerified: item.isVerified,
          category: item.category || "Marine Equipment",
          brand: item.brand || "OEM Standard",
          condition: (item.condition as any) || "Brand New (OEM)",
          classApproval: item.classApprovals && item.classApprovals.length > 0 ? item.classApprovals : ["DNV", "MED Wheelmark"],
          inStock: item.inStock
        }));
        setProducts(mapped);
        setTotalCount(res.totalCount);
      } else {
        setProducts([]);
        setTotalCount(0);
      }
      setIsLoading(false);
    }

    const timer = setTimeout(() => {
      loadDatabaseProducts();
    }, 200);

    return () => {
      isMounted = false;
      clearTimeout(timer);
    };
  }, [searchQuery, selectedPort, selectedCondition, verifiedOnly, currentPage, pageSize]);

  const toggleClass = (c: string) => {
    handleFilterChange(() => {
      setSelectedClass(prev => 
        prev.includes(c) ? prev.filter(x => x !== c) : [...prev, c]
      );
    });
  };

  const filteredListings = useMemo(() => {
    return products.filter(item => {
      const matchStock = !inStockOnly || item.inStock;
      const matchClass = selectedClass.length === 0 || 
        (item.classApproval && selectedClass.some(c => item.classApproval?.includes(c)));

      return matchStock && matchClass;
    }).sort((a, b) => {
      if (sortBy === "price-asc") {
        return parseFloat(a.price?.replace(/,/g, '') || "0") - parseFloat(b.price?.replace(/,/g, '') || "0");
      }
      if (sortBy === "price-desc") {
        return parseFloat(b.price?.replace(/,/g, '') || "0") - parseFloat(a.price?.replace(/,/g, '') || "0");
      }
      return 0;
    });
  }, [products, selectedClass, inStockOnly, sortBy]);

  const clearAllFilters = () => {
    setCurrentPage(1);
    setSearchQuery("");
    setSelectedPort("All Ports");
    setSelectedCondition("All Conditions");
    setSelectedClass([]);
    setVerifiedOnly(false);
    setInStockOnly(false);
  };

  const handlePageChange = (page: number) => {
    if (page >= 1 && page <= totalPages && page !== currentPage) {
      setCurrentPage(page);
      window.scrollTo({ top: 220, behavior: "smooth" });
    }
  };

  // Generate pagination buttons array with ellipsis
  const paginationPages = useMemo(() => {
    const pages: (number | string)[] = [];
    if (totalPages <= 7) {
      for (let i = 1; i <= totalPages; i++) pages.push(i);
    } else {
      pages.push(1);
      if (currentPage > 3) pages.push("...");
      
      const start = Math.max(2, currentPage - 1);
      const end = Math.min(totalPages - 1, currentPage + 1);
      
      for (let i = start; i <= end; i++) pages.push(i);
      
      if (currentPage < totalPages - 2) pages.push("...");
      pages.push(totalPages);
    }
    return pages;
  }, [currentPage, totalPages]);

  return (
    <>
      <Navbar />
      <main className="min-h-screen bg-background pt-24 pb-20">
        
        {/* Header Bar */}
        <section id="marketplace-top" className="bg-slate-100/60 dark:bg-slate-900/40 border-b border-border py-8 mb-8">
          <div className="container mx-auto px-6 flex flex-col md:flex-row md:items-center justify-between gap-4">
            <div>
              <div className="flex items-center gap-2 text-xs font-bold text-primary uppercase tracking-wider mb-1">
                <Ship size={14} />
                <span>Live Database Marketplace</span>
              </div>
              <h1 className="text-3xl md:text-4xl font-black tracking-tight text-foreground">
                Ship Supplies & Technical Spare Parts
              </h1>
              <p className="text-sm text-muted-foreground mt-1">
                Explore {totalCount.toLocaleString()} verified products with 24-item live pagination.
              </p>
            </div>

            <div className="flex items-center gap-3">
              <span className="text-xs font-semibold px-3.5 py-1.5 rounded-full bg-green-500/10 text-green-600 dark:text-green-400 border border-green-500/20 flex items-center gap-1.5">
                <span className="w-2 h-2 rounded-full bg-green-500 animate-pulse"></span>
                <span>{totalCount.toLocaleString()} Products in DB</span>
              </span>
              <span className="text-xs font-semibold px-3 py-1.5 rounded-full bg-primary/10 text-primary border border-primary/20">
                Page {currentPage} of {totalPages}
              </span>
            </div>
          </div>
        </section>

        <div className="container mx-auto px-6 flex flex-col lg:flex-row gap-8">
          
          {/* Advanced Sidebar Filters */}
          <aside className="w-full lg:w-80 flex-shrink-0">
            <div className="glass-card p-6 rounded-3xl sticky top-28 space-y-6 border border-border shadow-sm">
              
              {/* Filter Header */}
              <div className="flex items-center justify-between pb-4 border-b border-border">
                <h2 className="font-bold text-base text-foreground flex items-center gap-2">
                  <Filter size={18} className="text-primary" />
                  <span>Technical Filters</span>
                </h2>
                <button 
                  onClick={clearAllFilters}
                  className="text-xs text-primary hover:underline flex items-center gap-1 font-semibold cursor-pointer"
                >
                  <RotateCcw size={12} />
                  <span>Reset</span>
                </button>
              </div>

              {/* Port / Delivery Hub */}
              <div>
                <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-2.5 block flex items-center gap-1.5">
                  <MapPin size={14} className="text-primary" />
                  <span>Port of Delivery (Port of Call)</span>
                </label>
                <div className="space-y-1.5 max-h-48 overflow-y-auto pr-1">
                  {PORTS.map(port => (
                    <button
                      key={port}
                      onClick={() => handleFilterChange(() => setSelectedPort(port))}
                      className={`w-full text-left px-3 py-2 rounded-xl text-xs font-medium transition-colors flex items-center justify-between cursor-pointer ${
                        selectedPort === port 
                          ? "bg-primary text-white font-bold shadow-md shadow-primary/20" 
                          : "text-muted-foreground hover:bg-slate-100 dark:hover:bg-slate-800 hover:text-foreground"
                      }`}
                    >
                      <span>{port}</span>
                      {selectedPort === port && <CheckCircle2 size={14} />}
                    </button>
                  ))}
                </div>
              </div>

              {/* Condition Filter */}
              <div>
                <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-2.5 block flex items-center gap-1.5">
                  <Award size={14} className="text-primary" />
                  <span>Product Condition</span>
                </label>
                <div className="space-y-1.5">
                  {CONDITIONS.map(cond => (
                    <button
                      key={cond}
                      onClick={() => handleFilterChange(() => setSelectedCondition(cond))}
                      className={`w-full text-left px-3 py-2 rounded-xl text-xs font-medium transition-colors flex items-center justify-between cursor-pointer ${
                        selectedCondition === cond 
                          ? "bg-primary text-white font-bold shadow-md shadow-primary/20" 
                          : "text-muted-foreground hover:bg-slate-100 dark:hover:bg-slate-800 hover:text-foreground"
                      }`}
                    >
                      <span>{cond}</span>
                      {selectedCondition === cond && <CheckCircle2 size={14} />}
                    </button>
                  ))}
                </div>
              </div>

              {/* Class Approval & Certifications */}
              <div>
                <label className="text-xs font-bold uppercase tracking-wider text-muted-foreground mb-2.5 block flex items-center gap-1.5">
                  <ShieldCheck size={14} className="text-primary" />
                  <span>Class Approval / Certification</span>
                </label>
                <div className="flex flex-wrap gap-1.5">
                  {CLASS_APPROVALS.map(cl => {
                    const active = selectedClass.includes(cl);
                    return (
                      <button
                        key={cl}
                        onClick={() => toggleClass(cl)}
                        className={`px-2.5 py-1.5 rounded-lg text-xs font-semibold transition-colors border cursor-pointer ${
                          active
                            ? "bg-primary text-white border-primary"
                            : "bg-background border-border text-muted-foreground hover:border-primary/50"
                        }`}
                      >
                        {cl}
                      </button>
                    );
                  })}
                </div>
              </div>

              {/* Quick Checkboxes */}
              <div className="pt-4 border-t border-border space-y-3">
                <label className="flex items-center gap-3 cursor-pointer group">
                  <input
                    type="checkbox"
                    checked={verifiedOnly}
                    onChange={(e) => handleFilterChange(() => setVerifiedOnly(e.target.checked))}
                    className="w-4 h-4 rounded text-primary focus:ring-primary border-border cursor-pointer"
                  />
                  <span className="text-xs font-medium text-foreground group-hover:text-primary transition-colors flex items-center gap-1">
                    <ShieldCheck size={14} className="text-blue-500" />
                    Verified Suppliers Only
                  </span>
                </label>

                <label className="flex items-center gap-3 cursor-pointer group">
                  <input
                    type="checkbox"
                    checked={inStockOnly}
                    onChange={(e) => setInStockOnly(e.target.checked)}
                    className="w-4 h-4 rounded text-primary focus:ring-primary border-border cursor-pointer"
                  />
                  <span className="text-xs font-medium text-foreground group-hover:text-primary transition-colors flex items-center gap-1">
                    <CheckCircle2 size={14} className="text-green-500" />
                    Ready in Stock (Immediate Dispatch)
                  </span>
                </label>
              </div>

            </div>
          </aside>

          {/* Main Marketplace Area */}
          <div className="flex-1 space-y-6">
            
            {/* Search & Sort Bar */}
            <div className="glass-card p-3 rounded-2xl flex flex-col sm:flex-row items-center justify-between gap-4 border border-border">
              <div className="relative w-full flex-1">
                <Search size={18} className="absolute left-4 top-1/2 -translate-y-1/2 text-muted-foreground" />
                <input
                  type="text"
                  value={searchQuery}
                  onChange={(e) => handleFilterChange(() => setSearchQuery(e.target.value))}
                  placeholder="Search database by IMPA code, Part No, Brand (Furuno, Yanmar, Alfa Laval) or keyword..."
                  className="w-full pl-11 pr-4 py-3 rounded-xl bg-background/50 border border-transparent focus:bg-background focus:border-primary outline-none text-sm transition-all text-foreground"
                />
              </div>

              <div className="flex items-center gap-3 w-full sm:w-auto">
                <select
                  value={sortBy}
                  onChange={(e) => setSortBy(e.target.value as any)}
                  className="px-4 py-3 rounded-xl bg-background border border-border text-xs font-bold text-foreground outline-none cursor-pointer hover:border-primary transition-colors"
                >
                  <option value="featured">Featured / Latest First</option>
                  <option value="price-asc">Price: Low to High</option>
                  <option value="price-desc">Price: High to Low</option>
                </select>
              </div>
            </div>

            {/* Active Filter Chips */}
            {(selectedPort !== "All Ports" || selectedCondition !== "All Conditions" || selectedClass.length > 0 || verifiedOnly || inStockOnly || searchQuery) && (
              <div className="flex flex-wrap items-center gap-2 pt-1">
                <span className="text-xs text-muted-foreground">Active Filters:</span>
                {selectedPort !== "All Ports" && (
                  <span className="px-2.5 py-1 rounded-full bg-primary/10 text-primary text-xs font-semibold flex items-center gap-1">
                    Port: {selectedPort}
                    <button onClick={() => handleFilterChange(() => setSelectedPort("All Ports"))}>×</button>
                  </span>
                )}
                {selectedCondition !== "All Conditions" && (
                  <span className="px-2.5 py-1 rounded-full bg-primary/10 text-primary text-xs font-semibold flex items-center gap-1">
                    {selectedCondition}
                    <button onClick={() => handleFilterChange(() => setSelectedCondition("All Conditions"))}>×</button>
                  </span>
                )}
                {selectedClass.map(c => (
                  <span key={c} className="px-2.5 py-1 rounded-full bg-primary/10 text-primary text-xs font-semibold flex items-center gap-1">
                    Class: {c}
                    <button onClick={() => toggleClass(c)}>×</button>
                  </span>
                ))}
                {verifiedOnly && (
                  <span className="px-2.5 py-1 rounded-full bg-blue-500/10 text-blue-600 dark:text-blue-400 text-xs font-semibold flex items-center gap-1">
                    Verified Only
                    <button onClick={() => handleFilterChange(() => setVerifiedOnly(false))}>×</button>
                  </span>
                )}
                {inStockOnly && (
                  <span className="px-2.5 py-1 rounded-full bg-green-500/10 text-green-600 dark:text-green-400 text-xs font-semibold flex items-center gap-1">
                    In Stock
                    <button onClick={() => setInStockOnly(false)}>×</button>
                  </span>
                )}
              </div>
            )}

            {/* Results Counter & Loading status */}
            <div className="flex items-center justify-between text-xs text-muted-foreground px-1">
              <span className="flex items-center gap-2">
                {isLoading && <Loader2 size={13} className="animate-spin text-primary" />}
                Showing <strong>{((currentPage - 1) * pageSize) + 1} - {Math.min(currentPage * pageSize, totalCount)}</strong> of <strong>{totalCount.toLocaleString()}</strong> items
              </span>
              <span>24 items / page • Direct Quotations</span>
            </div>

            {/* Product Cards Grid or Loading Shimmer */}
            {isLoading ? (
              <div className="grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 gap-6">
                {[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12].map((i) => (
                  <div key={i} className="glass-card rounded-3xl p-5 border border-border animate-pulse space-y-4">
                    <div className="w-full h-48 bg-slate-200 dark:bg-slate-800 rounded-2xl" />
                    <div className="h-4 bg-slate-200 dark:bg-slate-800 rounded-full w-3/4" />
                    <div className="h-3 bg-slate-200 dark:bg-slate-800 rounded-full w-1/2" />
                    <div className="flex justify-between items-center pt-3 border-t border-border">
                      <div className="h-4 bg-slate-200 dark:bg-slate-800 rounded-full w-20" />
                      <div className="h-8 bg-slate-200 dark:bg-slate-800 rounded-xl w-24" />
                    </div>
                  </div>
                ))}
              </div>
            ) : filteredListings.length > 0 ? (
              <div className="grid grid-cols-1 md:grid-cols-2 xl:grid-cols-3 gap-6">
                {filteredListings.map((product, index) => (
                  <ProductCard key={product.id} product={product} index={index} />
                ))}
              </div>
            ) : (
              <div className="glass-card p-12 rounded-3xl text-center border border-border space-y-4">
                <PackageSearch size={48} className="mx-auto text-muted-foreground/40" />
                <h3 className="text-lg font-bold text-foreground">No products found in database</h3>
                <p className="text-sm text-muted-foreground max-w-md mx-auto">
                  No records matched your search query or filter criteria in the database.
                </p>
                <button
                  onClick={clearAllFilters}
                  className="px-5 py-2.5 rounded-xl bg-primary text-white text-sm font-semibold hover:bg-primary/90 transition-colors shadow-md cursor-pointer"
                >
                  Reset All Filters
                </button>
              </div>
            )}

            {/* Apple-Style Pagination Bar */}
            {totalPages > 1 && (
              <div className="pt-8 pb-4 flex flex-col sm:flex-row items-center justify-between gap-4 border-t border-border">
                <div className="text-xs text-muted-foreground">
                  Page <strong>{currentPage}</strong> of <strong>{totalPages}</strong> ({totalCount.toLocaleString()} total items)
                </div>

                <div className="flex items-center gap-1.5">
                  {/* First Page */}
                  <button
                    onClick={() => handlePageChange(1)}
                    disabled={currentPage === 1}
                    className="p-2 rounded-xl glass-card text-foreground hover:bg-slate-100 dark:hover:bg-slate-800 disabled:opacity-30 disabled:pointer-events-none transition-colors cursor-pointer"
                    title="First Page"
                  >
                    <ChevronsLeft size={16} />
                  </button>

                  {/* Previous Page */}
                  <button
                    onClick={() => handlePageChange(currentPage - 1)}
                    disabled={currentPage === 1}
                    className="p-2 rounded-xl glass-card text-foreground hover:bg-slate-100 dark:hover:bg-slate-800 disabled:opacity-30 disabled:pointer-events-none transition-colors cursor-pointer"
                    title="Previous Page"
                  >
                    <ChevronLeft size={16} />
                  </button>

                  {/* Page Numbers */}
                  <div className="flex items-center gap-1 px-1">
                    {paginationPages.map((page, idx) => {
                      if (page === "...") {
                        return (
                          <span key={`ellipsis-${idx}`} className="px-2 text-xs text-muted-foreground">
                            ...
                          </span>
                        );
                      }
                      const pageNum = page as number;
                      const isActive = pageNum === currentPage;
                      return (
                        <button
                          key={pageNum}
                          onClick={() => handlePageChange(pageNum)}
                          className={`w-9 h-9 rounded-xl text-xs font-bold transition-all cursor-pointer ${
                            isActive
                              ? "bg-primary text-white shadow-md shadow-primary/30 scale-105"
                              : "glass-card text-foreground hover:bg-slate-100 dark:hover:bg-slate-800"
                          }`}
                        >
                          {pageNum}
                        </button>
                      );
                    })}
                  </div>

                  {/* Next Page */}
                  <button
                    onClick={() => handlePageChange(currentPage + 1)}
                    disabled={currentPage === totalPages}
                    className="p-2 rounded-xl glass-card text-foreground hover:bg-slate-100 dark:hover:bg-slate-800 disabled:opacity-30 disabled:pointer-events-none transition-colors cursor-pointer"
                    title="Next Page"
                  >
                    <ChevronRight size={16} />
                  </button>

                  {/* Last Page */}
                  <button
                    onClick={() => handlePageChange(totalPages)}
                    disabled={currentPage === totalPages}
                    className="p-2 rounded-xl glass-card text-foreground hover:bg-slate-100 dark:hover:bg-slate-800 disabled:opacity-30 disabled:pointer-events-none transition-colors cursor-pointer"
                    title="Last Page"
                  >
                    <ChevronsRight size={16} />
                  </button>
                </div>
              </div>
            )}

          </div>
        </div>
      </main>
    </>
  );
}
