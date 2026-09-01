"use client";

import React, { useState, useEffect } from "react";
import { Navbar } from "@/components/navbar";
import { Search, BookOpen, Layers, ShieldCheck, ChevronRight, FileText, Anchor, Loader2, PackageSearch } from "lucide-react";
import { motion } from "framer-motion";
import Link from "next/link";
import { apiClient, ApiImpaGroup } from "@/lib/api";

export default function ImpaCodesDirectoryPage() {
  const [sections, setSections] = useState<ApiImpaGroup[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [searchQuery, setSearchQuery] = useState("");

  useEffect(() => {
    let isMounted = true;
    async function loadImpaCodes() {
      setIsLoading(true);
      const res = await apiClient.getImpaCodes(searchQuery || undefined);
      if (!isMounted) return;
      if (res && res.length > 0) {
        setSections(res);
      } else {
        setSections([]);
      }
      setIsLoading(false);
    }
    const timer = setTimeout(() => {
      loadImpaCodes();
    }, 250);
    return () => {
      isMounted = false;
      clearTimeout(timer);
    };
  }, [searchQuery]);

  return (
    <>
      <Navbar />
      <main className="min-h-screen bg-background pt-24 pb-20">
        
        {/* Header Bar */}
        <section className="bg-slate-100/60 dark:bg-slate-900/40 border-b border-border py-8 mb-8">
          <div className="container mx-auto px-6 flex flex-col md:flex-row md:items-center justify-between gap-4">
            <div>
              <div className="flex items-center gap-2 text-xs font-bold text-primary uppercase tracking-wider mb-1">
                <BookOpen size={14} />
                <span>Live Database IMPA Catalog</span>
              </div>
              <h1 className="text-3xl md:text-4xl font-black tracking-tight text-foreground">
                IMPA Marine Stores Guide
              </h1>
              <p className="text-sm text-muted-foreground mt-1">
                Explore 2-digit major divisions dynamically cataloged from registered database items.
              </p>
            </div>

            <div className="flex items-center gap-3">
              <span className="text-xs font-semibold px-3 py-1.5 rounded-full bg-primary/10 text-primary border border-primary/20">
                {sections.length} Active IMPA Divisions
              </span>
            </div>
          </div>
        </section>

        <div className="container mx-auto px-6 space-y-8">
          
          {/* Search Bar */}
          <div className="glass-card p-4 rounded-2xl flex items-center gap-3 border border-border max-w-2xl">
            <Search size={18} className="text-muted-foreground ml-2" />
            <input
              type="text"
              value={searchQuery}
              onChange={(e) => setSearchQuery(e.target.value)}
              placeholder="Search by 2-digit or 6-digit IMPA code (e.g. 33, 37 27 03)..."
              className="w-full bg-transparent outline-none text-sm text-foreground placeholder:text-muted-foreground"
            />
          </div>

          {/* IMPA Groups Grid */}
          {isLoading ? (
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {[1, 2, 3, 4, 5, 6].map((i) => (
                <div key={i} className="glass-card rounded-3xl p-6 border border-border animate-pulse space-y-3">
                  <div className="h-6 bg-slate-200 dark:bg-slate-800 rounded-full w-24" />
                  <div className="h-5 bg-slate-200 dark:bg-slate-800 rounded-full w-3/4" />
                  <div className="h-3 bg-slate-200 dark:bg-slate-800 rounded-full w-1/2" />
                </div>
              ))}
            </div>
          ) : sections.length > 0 ? (
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {sections.map((sec, index) => (
                <motion.div
                  key={sec.code}
                  initial={{ opacity: 0, y: 15 }}
                  animate={{ opacity: 1, y: 0 }}
                  transition={{ duration: 0.3, delay: index * 0.03 }}
                  className="glass-card rounded-3xl p-6 border border-border hover:border-primary/40 transition-all flex flex-col justify-between group shadow-sm hover:shadow-lg space-y-4"
                >
                  <div className="space-y-3">
                    <div className="flex items-center justify-between">
                      <div className="px-3 py-1.5 rounded-xl bg-primary/10 border border-primary/20 text-primary font-black text-sm">
                        Section {sec.code}
                      </div>
                      <span className="text-xs font-bold text-muted-foreground">
                        {sec.count} Items
                      </span>
                    </div>

                    <h3 className="font-bold text-base text-foreground group-hover:text-primary transition-colors">
                      {sec.name}
                    </h3>

                    <p className="text-xs text-muted-foreground line-clamp-2">
                      {sec.description}
                    </p>

                    {/* Sample Code Badges */}
                    {sec.sampleCodes && sec.sampleCodes.length > 0 && (
                      <div className="pt-2 flex flex-wrap gap-1.5">
                        {sec.sampleCodes.map(code => (
                          <span key={code} className="px-2 py-0.5 rounded-md bg-slate-100 dark:bg-slate-800 text-[11px] font-mono text-muted-foreground">
                            {code}
                          </span>
                        ))}
                      </div>
                    )}
                  </div>

                  <div className="pt-3 border-t border-border flex items-center justify-between">
                    <Link
                      href={`/listings?impaCode=${sec.code}`}
                      className="text-xs font-bold text-primary flex items-center gap-1 group-hover:translate-x-1 transition-transform"
                    >
                      <span>Explore Section Listings</span>
                      <ChevronRight size={14} />
                    </Link>
                  </div>
                </motion.div>
              ))}
            </div>
          ) : (
            <div className="glass-card p-12 rounded-3xl text-center border border-border space-y-4">
              <PackageSearch size={48} className="mx-auto text-muted-foreground/40" />
              <h3 className="text-lg font-bold text-foreground">No IMPA sections found</h3>
              <p className="text-sm text-muted-foreground max-w-md mx-auto">
                No items matching that IMPA division code were found in the database.
              </p>
            </div>
          )}

        </div>
      </main>
    </>
  );
}
