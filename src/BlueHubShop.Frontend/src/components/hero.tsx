"use client";

import React, { useState } from "react";
import { motion } from "framer-motion";
import { Search, Anchor, ShieldCheck, Ship, Clock, Globe, ArrowRight, Sparkles, ChevronDown } from "lucide-react";
import Image from "next/image";
import { useRouter } from "next/navigation";
import Link from "next/link";

export function Hero() {
  const [searchTerm, setSearchTerm] = useState("");
  const router = useRouter();

  const handleSearch = (e: React.FormEvent) => {
    e.preventDefault();
    if (searchTerm.trim()) {
      router.push(`/listings?search=${encodeURIComponent(searchTerm.trim())}`);
    } else {
      router.push(`/listings`);
    }
  };

  const scrollToNext = () => {
    window.scrollTo({ top: window.innerHeight, behavior: "smooth" });
  };

  return (
    <section className="relative min-h-screen flex flex-col justify-between overflow-hidden pt-24 pb-8 border-b border-slate-200/80 dark:border-white/10">
      
      {/* Dynamic Background Image Layers with Smooth Crossfade */}
      <div className="absolute inset-0 z-0 overflow-hidden">
        {/* Daylight Sunny Cargo Ship (Light Mode) */}
        <div className="absolute inset-0 transition-opacity duration-700 ease-in-out opacity-100 dark:opacity-0">
          <Image
            src="/images/hero-day.jpg"
            alt="Commercial Cargo Ship - Daylight Maritime Trade"
            fill
            priority
            sizes="100vw"
            className="object-cover object-center"
          />
          {/* Light Mode Progressive Bottom-to-Top Gradient Blur Layer */}
          <div 
            className="absolute inset-0 backdrop-blur-md" 
            style={{
              maskImage: "linear-gradient(to top, rgba(0,0,0,1) 0%, rgba(0,0,0,0.6) 25%, rgba(0,0,0,0) 65%)",
              WebkitMaskImage: "linear-gradient(to top, rgba(0,0,0,1) 0%, rgba(0,0,0,0.6) 25%, rgba(0,0,0,0) 65%)"
            }}
          />
        </div>

        {/* Nighttime Illuminated Cargo Ship (Dark Mode) */}
        <div className="absolute inset-0 transition-opacity duration-700 ease-in-out opacity-0 dark:opacity-100">
          <Image
            src="/images/hero-night.jpg"
            alt="Commercial Cargo Ship - Night Navigation"
            fill
            priority
            sizes="100vw"
            className="object-cover object-center"
          />
          {/* Dark Mode Moonlit Nautical Overlay */}
          <div className="absolute inset-0 bg-gradient-to-b from-slate-950/70 via-slate-950/50 to-background/95 backdrop-blur-[0.5px]" />
        </div>
      </div>

      {/* Main Hero Content */}
      <div className="container relative z-20 mx-auto px-6 my-auto">
        <div className="max-w-4xl mx-auto text-center">
          
          {/* Top Badge */}
          <motion.div
            initial={{ opacity: 0, y: 15 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.5, delay: 0.1 }}
            className="flex items-center justify-center gap-2 mb-4 md:mb-6"
          >
            <span className="inline-flex items-center gap-2 py-1.5 px-4 rounded-full bg-white/90 dark:bg-slate-900/90 backdrop-blur-md text-xs font-bold text-sky-700 dark:text-sky-400 tracking-wider uppercase border border-sky-200/90 dark:border-sky-800 shadow-sm">
              <Ship size={14} className="text-sky-600 dark:text-sky-400" />
              <span>International B2B Maritime Supply Platform</span>
            </span>
          </motion.div>
          
          {/* Main Title */}
          <motion.h1
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.6, delay: 0.2 }}
            className="text-4xl sm:text-5xl md:text-6xl lg:text-7xl font-black tracking-tight text-slate-900 dark:text-white mb-4 md:mb-6 leading-[1.1] drop-shadow-xs"
          >
            Direct Global <span className="text-transparent bg-clip-text bg-gradient-to-r from-sky-600 via-blue-600 to-indigo-700 dark:from-sky-400 dark:via-cyan-300 dark:to-teal-300">Ship Supply</span> & Spare Parts
          </motion.h1>
          
          {/* Subtitle */}
          <motion.p
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.6, delay: 0.3 }}
            className="text-sm sm:text-base md:text-lg text-slate-700 dark:text-slate-200 mb-8 max-w-2xl mx-auto font-medium leading-relaxed drop-shadow-2xs"
          >
            Connect directly with certified stockists in <strong>Tuzla, Rotterdam, Singapore & Houston</strong>. Search by IMPA/ISSA code or OEM part number for instant official RFQ quotations.
          </motion.p>

          {/* Search Bar */}
          <motion.form
            onSubmit={handleSearch}
            initial={{ opacity: 0, y: 25 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ duration: 0.6, delay: 0.4 }}
            className="w-full max-w-3xl mx-auto bg-white/95 dark:bg-slate-900/90 backdrop-blur-xl p-2 md:p-2.5 rounded-2xl md:rounded-full flex flex-col md:flex-row items-center gap-2 shadow-[0_10px_35px_-5px_rgba(0,0,0,0.15)] dark:shadow-2xl border border-slate-200/90 dark:border-slate-800"
          >
            <div className="flex-1 flex items-center gap-3 w-full bg-slate-50/90 dark:bg-slate-950/60 rounded-full px-5 py-3.5 border border-slate-200/80 dark:border-white/10">
              <Search className="text-sky-600 dark:text-sky-400 flex-shrink-0" size={20} />
              <input 
                type="text" 
                value={searchTerm}
                onChange={(e) => setSearchTerm(e.target.value)}
                placeholder="Search IMPA code (e.g. 33 01 01), OEM Part No, or Brand (Yanmar, Furuno)..." 
                className="bg-transparent border-none outline-none w-full text-slate-900 dark:text-white placeholder:text-slate-500 text-sm md:text-base font-semibold"
              />
            </div>
            <button 
              type="submit"
              className="w-full md:w-auto px-8 py-3.5 bg-gradient-to-r from-sky-600 to-blue-700 hover:from-sky-500 hover:to-blue-600 text-white rounded-full font-bold text-sm transition-all hover:scale-[1.02] flex items-center justify-center gap-2 shadow-md shadow-sky-600/30 cursor-pointer"
            >
              <Anchor size={18} />
              <span>Search Database</span>
            </button>
          </motion.form>

          {/* Popular Tag Chips */}
          <motion.div
            initial={{ opacity: 0 }}
            animate={{ opacity: 1 }}
            transition={{ duration: 0.5, delay: 0.5 }}
            className="mt-4 flex flex-wrap items-center justify-center gap-2 text-xs text-slate-600 dark:text-slate-300"
          >
            <span className="font-bold text-slate-800 dark:text-slate-100">Popular Searches:</span>
            {["IMPA 33 01", "Mooring Ropes", "Wilden Pump", "Anode Zinc", "Alfa Laval", "GMDSS VHF"].map((tag) => (
              <Link
                key={tag}
                href={`/listings?search=${encodeURIComponent(tag)}`}
                className="px-2.5 py-1 rounded-lg bg-white/80 dark:bg-slate-900/80 backdrop-blur-sm hover:bg-sky-50 dark:hover:bg-slate-800 text-slate-700 dark:text-slate-300 hover:text-sky-600 dark:hover:text-sky-400 border border-slate-200/90 dark:border-slate-800 transition-colors cursor-pointer shadow-2xs font-medium"
              >
                {tag}
              </Link>
            ))}
          </motion.div>

        </div>
      </div>

      {/* Trust Stats Bar & Scroll Indicator (Bottom of Hero) */}
      <div className="container relative z-20 mx-auto px-6 pt-6">
        <motion.div 
          initial={{ opacity: 0, y: 20 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ duration: 0.7, delay: 0.6 }}
          className="grid grid-cols-2 md:grid-cols-4 gap-4 max-w-5xl mx-auto"
        >
          <div className="bg-white/90 dark:bg-slate-900/90 backdrop-blur-xl p-4 sm:p-5 rounded-2xl border border-slate-200/90 dark:border-slate-800 text-center shadow-[0_4px_20px_-4px_rgba(0,0,0,0.08)] dark:shadow-none transition-transform hover:-translate-y-0.5">
            <div className="text-xl sm:text-2xl md:text-3xl font-black text-slate-900 dark:text-white">4,900+</div>
            <div className="text-xs text-sky-700 dark:text-sky-400 font-bold mt-0.5 sm:mt-1">OEM Parts & IMPA Items</div>
          </div>
          <div className="bg-white/90 dark:bg-slate-900/90 backdrop-blur-xl p-4 sm:p-5 rounded-2xl border border-slate-200/90 dark:border-slate-800 text-center shadow-[0_4px_20px_-4px_rgba(0,0,0,0.08)] dark:shadow-none transition-transform hover:-translate-y-0.5">
            <div className="text-xl sm:text-2xl md:text-3xl font-black text-slate-900 dark:text-white">50+</div>
            <div className="text-xs text-sky-700 dark:text-sky-400 font-bold mt-0.5 sm:mt-1">Major Commercial Ports</div>
          </div>
          <div className="bg-white/90 dark:bg-slate-900/90 backdrop-blur-xl p-4 sm:p-5 rounded-2xl border border-slate-200/90 dark:border-slate-800 text-center shadow-[0_4px_20px_-4px_rgba(0,0,0,0.08)] dark:shadow-none transition-transform hover:-translate-y-0.5">
            <div className="text-xl sm:text-2xl md:text-3xl font-black text-slate-900 dark:text-white">100%</div>
            <div className="text-xs text-sky-700 dark:text-sky-400 font-bold mt-0.5 sm:mt-1">Verified Marine Stockists</div>
          </div>
          <div className="bg-white/90 dark:bg-slate-900/90 backdrop-blur-xl p-4 sm:p-5 rounded-2xl border border-slate-200/90 dark:border-slate-800 text-center shadow-[0_4px_20px_-4px_rgba(0,0,0,0.08)] dark:shadow-none transition-transform hover:-translate-y-0.5">
            <div className="text-xl sm:text-2xl md:text-3xl font-black text-slate-900 dark:text-white">&lt; 1 Hour</div>
            <div className="text-xs text-sky-700 dark:text-sky-400 font-bold mt-0.5 sm:mt-1">Average Quotation Response</div>
          </div>
        </motion.div>

        {/* Subtle Scroll Down Prompt */}
        <motion.div 
          initial={{ opacity: 0 }}
          animate={{ opacity: 1 }}
          transition={{ delay: 1, duration: 0.5 }}
          className="flex justify-center mt-3"
        >
          <button 
            onClick={scrollToNext}
            className="text-slate-500 hover:text-sky-600 dark:hover:text-sky-400 transition-colors animate-bounce p-1 cursor-pointer"
            aria-label="Scroll to explore"
          >
            <ChevronDown size={20} />
          </button>
        </motion.div>
      </div>

    </section>
  );
}
