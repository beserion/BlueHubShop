"use client";

import React, { useState, useEffect, useMemo } from "react";
import { Navbar } from "@/components/navbar";
import { 
  Search, MapPin, Building2, Star, ShieldCheck, Mail, 
  ExternalLink, Filter, Anchor, Clock, Globe2, Award, 
  CheckCircle2, Phone, Briefcase, ChevronRight, Loader2, PackageSearch
} from "lucide-react";
import { motion } from "framer-motion";
import Link from "next/link";
import { apiClient, ApiCompany } from "@/lib/api";

export default function StoresPage() {
  const [companies, setCompanies] = useState<ApiCompany[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [searchQuery, setSearchQuery] = useState("");
  const [selectedCity, setSelectedCity] = useState("All Cities");

  useEffect(() => {
    let isMounted = true;
    async function loadCompanies() {
      setIsLoading(true);
      const res = await apiClient.getCompanies({
        search: searchQuery || undefined,
        city: selectedCity !== "All Cities" ? selectedCity : undefined
      });
      if (!isMounted) return;
      if (res) {
        setCompanies(res);
      } else {
        setCompanies([]);
      }
      setIsLoading(false);
    }
    loadCompanies();
    return () => { isMounted = false; };
  }, [searchQuery, selectedCity]);

  const cities = useMemo(() => {
    const set = new Set<string>();
    companies.forEach(c => {
      if (c.city) set.add(c.city);
    });
    return ["All Cities", ...Array.from(set)];
  }, [companies]);

  return (
    <>
      <Navbar />
      <main className="min-h-screen bg-background pt-24 pb-20">
        
        {/* Header Bar */}
        <section className="bg-slate-100/60 dark:bg-slate-900/40 border-b border-border py-8 mb-8">
          <div className="container mx-auto px-6 flex flex-col md:flex-row md:items-center justify-between gap-4">
            <div>
              <div className="flex items-center gap-2 text-xs font-bold text-primary uppercase tracking-wider mb-1">
                <Building2 size={14} />
                <span>Verified Maritime Companies Directory</span>
              </div>
              <h1 className="text-3xl md:text-4xl font-black tracking-tight text-foreground">
                Ship Chandlers & Technical Stockists
              </h1>
              <p className="text-sm text-muted-foreground mt-1">
                Directly connect with certified maritime supply stations and stockists in your database.
              </p>
            </div>

            <div className="flex items-center gap-3">
              <span className="text-xs font-semibold px-3 py-1.5 rounded-full bg-primary/10 text-primary border border-primary/20">
                {companies.length} Registered Companies
              </span>
            </div>
          </div>
        </section>

        <div className="container mx-auto px-6 space-y-8">
          
          {/* Search & Filter Bar */}
          <div className="glass-card p-4 rounded-2xl flex flex-col sm:flex-row items-center justify-between gap-4 border border-border">
            <div className="relative w-full flex-1">
              <Search size={18} className="absolute left-4 top-1/2 -translate-y-1/2 text-muted-foreground" />
              <input
                type="text"
                value={searchQuery}
                onChange={(e) => setSearchQuery(e.target.value)}
                placeholder="Search registered suppliers by company name, location, or equipment category..."
                className="w-full pl-11 pr-4 py-3 rounded-xl bg-background/50 border border-transparent focus:bg-background focus:border-primary outline-none text-sm transition-all text-foreground"
              />
            </div>

            <div className="flex items-center gap-3 w-full sm:w-auto">
              <select
                value={selectedCity}
                onChange={(e) => setSelectedCity(e.target.value)}
                className="px-4 py-3 rounded-xl bg-background border border-border text-xs font-bold text-foreground outline-none cursor-pointer hover:border-primary transition-colors"
              >
                {cities.map(ct => (
                  <option key={ct} value={ct}>{ct}</option>
                ))}
              </select>
            </div>
          </div>

          {/* Companies Grid */}
          {isLoading ? (
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {[1, 2, 3, 4, 5, 6].map((i) => (
                <div key={i} className="glass-card rounded-3xl p-6 border border-border animate-pulse space-y-4">
                  <div className="flex items-center gap-3">
                    <div className="w-12 h-12 rounded-2xl bg-slate-200 dark:bg-slate-800" />
                    <div className="space-y-2 flex-1">
                      <div className="h-4 bg-slate-200 dark:bg-slate-800 rounded-full w-3/4" />
                      <div className="h-3 bg-slate-200 dark:bg-slate-800 rounded-full w-1/2" />
                    </div>
                  </div>
                  <div className="h-16 bg-slate-200 dark:bg-slate-800 rounded-xl" />
                </div>
              ))}
            </div>
          ) : companies.length > 0 ? (
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {companies.map((store, index) => (
                <motion.div
                  key={store.id}
                  initial={{ opacity: 0, y: 15 }}
                  animate={{ opacity: 1, y: 0 }}
                  transition={{ duration: 0.3, delay: index * 0.05 }}
                  className="glass-card rounded-3xl p-6 border border-border hover:border-primary/40 transition-all flex flex-col justify-between group shadow-sm hover:shadow-lg space-y-5"
                >
                  
                  {/* Top Company Info */}
                  <div className="space-y-4">
                    <div className="flex items-start justify-between gap-3">
                      <div className="flex items-center gap-3">
                        <div className="w-12 h-12 rounded-2xl bg-primary/10 border border-primary/20 flex items-center justify-center text-primary font-black text-xl flex-shrink-0 group-hover:scale-105 transition-transform">
                          <Building2 size={24} />
                        </div>
                        <div>
                          <h3 className="font-extrabold text-base text-foreground group-hover:text-primary transition-colors line-clamp-1">
                            {store.name}
                          </h3>
                          <p className="text-xs font-semibold text-primary mt-0.5">
                            {store.companyType || "Ship Supply & Services"}
                          </p>
                        </div>
                      </div>

                      {store.isVerified && (
                        <span className="p-1.5 rounded-xl bg-blue-500/10 text-blue-500 flex-shrink-0" title="Verified Marine Supplier">
                          <ShieldCheck size={18} />
                        </span>
                      )}
                    </div>

                    <p className="text-xs text-muted-foreground line-clamp-2 leading-relaxed">
                      {store.description || "Certified maritime equipment provider and registered technical chandler."}
                    </p>

                    {/* Location & Ports */}
                    <div className="space-y-2 pt-2 border-t border-border text-xs">
                      <div className="flex items-center gap-1.5 text-muted-foreground">
                        <MapPin size={13} className="text-primary flex-shrink-0" />
                        <span className="font-medium truncate">{store.city ? `${store.city}, ${store.country || "Turkey"}` : "Global Maritime Ports"}</span>
                      </div>
                      <div className="flex items-center gap-1.5 text-muted-foreground">
                        <Anchor size={13} className="text-primary flex-shrink-0" />
                        <span className="truncate">Key Ports: {store.mainPorts && store.mainPorts.length > 0 ? store.mainPorts.join(", ") : "Tuzla, Rotterdam, Singapore"}</span>
                      </div>
                      {store.emailAddress && (
                        <div className="flex items-center gap-1.5 text-muted-foreground">
                          <Mail size={13} className="text-primary flex-shrink-0" />
                          <span className="truncate font-mono">{store.emailAddress}</span>
                        </div>
                      )}
                    </div>
                  </div>

                  {/* Action Link */}
                  <div className="pt-4 border-t border-border flex items-center justify-between">
                    <span className="text-xs font-bold text-muted-foreground">
                      {store.activeProductsCount} Active Listings
                    </span>
                    <Link
                      href={`/listings?supplier=${store.id}`}
                      className="px-4 py-2 rounded-xl bg-primary/10 hover:bg-primary text-primary hover:text-white font-bold text-xs transition-colors flex items-center gap-1"
                    >
                      <span>View Products</span>
                      <ChevronRight size={14} />
                    </Link>
                  </div>

                </motion.div>
              ))}
            </div>
          ) : (
            <div className="glass-card p-12 rounded-3xl text-center border border-border space-y-4">
              <PackageSearch size={48} className="mx-auto text-muted-foreground/40" />
              <h3 className="text-lg font-bold text-foreground">No companies found</h3>
              <p className="text-sm text-muted-foreground max-w-md mx-auto">
                No matching suppliers or stockists were found for your search term in the database.
              </p>
            </div>
          )}

        </div>
      </main>
    </>
  );
}
