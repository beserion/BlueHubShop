"use client";

import React, { useState, useEffect } from "react";
import { Navbar } from "@/components/navbar";
import { 
  Anchor, Wrench, Shield, Navigation, Droplets, Package, 
  Search, ChevronRight, Zap, Layers, Cpu, Flame, Wind, 
  Activity, Compass, Radio, Truck, FileText, LifeBuoy, 
  Cog, Gauge, HardHat, Disc, Ship, Loader2, PackageSearch
} from "lucide-react";
import { motion, AnimatePresence } from "framer-motion";
import Link from "next/link";
import { apiClient, ApiCategory } from "@/lib/api";

const CATEGORY_ICONS: Record<string, any> = {
  default: Layers,
  deck: Anchor,
  engine: Cog,
  spares: Wrench,
  safety: LifeBuoy,
  navcom: Navigation,
  chemicals: Droplets,
  provisions: Package,
  electrical: Zap,
  tools: HardHat,
  valves: Gauge,
  welding: Flame
};

export default function CategoriesPage() {
  const [categories, setCategories] = useState<ApiCategory[]>([]);
  const [isLoading, setIsLoading] = useState(true);
  const [searchQuery, setSearchQuery] = useState("");
  const [activeAccordion, setActiveAccordion] = useState<number | null>(null);

  useEffect(() => {
    let isMounted = true;
    async function loadCategories() {
      setIsLoading(true);
      const res = await apiClient.getCategories();
      if (!isMounted) return;
      if (res && res.length > 0) {
        setCategories(res);
      } else {
        setCategories([]);
      }
      setIsLoading(false);
    }
    loadCategories();
    return () => { isMounted = false; };
  }, []);

  const filteredCategories = categories.filter(cat => 
    cat.name.toLowerCase().includes(searchQuery.toLowerCase()) ||
    (cat.description && cat.description.toLowerCase().includes(searchQuery.toLowerCase()))
  );

  return (
    <>
      <Navbar />
      <main className="min-h-screen bg-background pt-24 pb-20">
        
        {/* Header Bar */}
        <section className="bg-slate-100/60 dark:bg-slate-900/40 border-b border-border py-8 mb-8">
          <div className="container mx-auto px-6 flex flex-col md:flex-row md:items-center justify-between gap-4">
            <div>
              <div className="flex items-center gap-2 text-xs font-bold text-primary uppercase tracking-wider mb-1">
                <Ship size={14} />
                <span>Live Database Taxonomy</span>
              </div>
              <h1 className="text-3xl md:text-4xl font-black tracking-tight text-foreground">
                Marine Supply Categories
              </h1>
              <p className="text-sm text-muted-foreground mt-1">
                Explore registered maritime supply categories from your SQL database.
              </p>
            </div>

            <div className="flex items-center gap-3">
              <span className="text-xs font-semibold px-3 py-1.5 rounded-full bg-primary/10 text-primary border border-primary/20">
                {categories.length} Categories Registered
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
              placeholder="Search category name..."
              className="w-full bg-transparent outline-none text-sm text-foreground placeholder:text-muted-foreground"
            />
          </div>

          {/* Categories Grid / List */}
          {isLoading ? (
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {[1, 2, 3, 4, 5, 6].map((i) => (
                <div key={i} className="glass-card rounded-3xl p-6 border border-border animate-pulse space-y-3">
                  <div className="w-12 h-12 rounded-2xl bg-slate-200 dark:bg-slate-800" />
                  <div className="h-5 bg-slate-200 dark:bg-slate-800 rounded-full w-3/4" />
                  <div className="h-3 bg-slate-200 dark:bg-slate-800 rounded-full w-1/2" />
                </div>
              ))}
            </div>
          ) : filteredCategories.length > 0 ? (
            <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6">
              {filteredCategories.map((cat, index) => {
                const IconComponent = CATEGORY_ICONS.default;

                return (
                  <motion.div
                    key={cat.id}
                    initial={{ opacity: 0, y: 15 }}
                    animate={{ opacity: 1, y: 0 }}
                    transition={{ duration: 0.3, delay: index * 0.04 }}
                    className="glass-card rounded-3xl p-6 border border-border hover:border-primary/40 transition-all flex flex-col justify-between group shadow-sm hover:shadow-lg space-y-4"
                  >
                    <div className="space-y-3">
                      <div className="flex items-center justify-between">
                        <div className="w-12 h-12 rounded-2xl bg-primary/10 border border-primary/20 flex items-center justify-center text-primary font-black text-xl group-hover:scale-105 transition-transform">
                          <IconComponent size={24} />
                        </div>
                        <span className="text-xs font-bold px-2.5 py-1 rounded-full bg-slate-100 dark:bg-slate-800 text-muted-foreground">
                          {cat.productCount} Items
                        </span>
                      </div>

                      <h3 className="font-bold text-base text-foreground group-hover:text-primary transition-colors">
                        {cat.name}
                      </h3>

                      {cat.description && (
                        <p className="text-xs text-muted-foreground line-clamp-2">
                          {cat.description}
                        </p>
                      )}
                    </div>

                    <div className="pt-3 border-t border-border flex items-center justify-between">
                      <span className="text-xs text-muted-foreground font-mono">{cat.code || `CAT-${cat.id}`}</span>
                      <Link
                        href={`/listings?categoryId=${cat.id}`}
                        className="text-xs font-bold text-primary flex items-center gap-1 group-hover:translate-x-1 transition-transform"
                      >
                        <span>Browse Items</span>
                        <ChevronRight size={14} />
                      </Link>
                    </div>
                  </motion.div>
                );
              })}
            </div>
          ) : (
            <div className="glass-card p-12 rounded-3xl text-center border border-border space-y-4">
              <PackageSearch size={48} className="mx-auto text-muted-foreground/40" />
              <h3 className="text-lg font-bold text-foreground">No categories found</h3>
              <p className="text-sm text-muted-foreground max-w-md mx-auto">
                No matching category was found in the database.
              </p>
            </div>
          )}

        </div>
      </main>
    </>
  );
}
