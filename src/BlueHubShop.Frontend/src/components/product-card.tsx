"use client";

import { motion } from "framer-motion";
import { Anchor, MapPin, Building2, ExternalLink, ShieldCheck, ChevronRight } from "lucide-react";
import Image from "next/image";
import Link from "next/link";

export interface ProductListing {
  id: string;
  title: string;
  impaCode?: string;
  issaCode?: string;
  oemPartNo?: string;
  price?: string;
  currency?: string;
  image: string;
  supplierName: string;
  location: string;
  portOfDelivery?: string[];
  isVerified: boolean;
  category: string;
}

interface ProductCardProps {
  product: ProductListing;
  index: number;
}

export function ProductCard({ product, index }: ProductCardProps) {
  return (
    <motion.div
      initial={{ opacity: 0, y: 15 }}
      animate={{ opacity: 1, y: 0 }}
      transition={{ duration: 0.4, delay: index * 0.05 }}
      className="glass-card rounded-3xl overflow-hidden group flex flex-col h-full hover:shadow-xl transition-all duration-300 hover:-translate-y-1.5 border border-slate-200/90 dark:border-slate-800/80 bg-white dark:bg-slate-900/60"
    >
      {/* Image Container */}
      <div className="relative h-48 w-full bg-slate-100 dark:bg-slate-800/60 overflow-hidden">
        <div className="absolute inset-0 flex items-center justify-center text-slate-300 dark:text-slate-700">
          <Anchor size={44} className="opacity-25" />
        </div>
        <Image
          src={product.image}
          alt={product.title}
          fill
          sizes="(max-width: 768px) 100vw, (max-width: 1200px) 50vw, 25vw"
          className="object-cover z-10 transition-transform duration-500 group-hover:scale-105"
        />
        
        {/* Category Pill */}
        <div className="absolute top-3 left-3 z-20">
          <span className="px-3 py-1 rounded-full bg-slate-900/80 backdrop-blur-md text-white text-[11px] font-bold border border-white/20 shadow-sm">
            {product.category}
          </span>
        </div>

        {/* Verified Badge */}
        {product.isVerified && (
          <div className="absolute top-3 right-3 z-20">
            <span className="flex items-center gap-1 px-2.5 py-1 rounded-full bg-sky-600/90 backdrop-blur-md text-white text-[11px] font-bold border border-sky-400/30 shadow-sm">
              <ShieldCheck size={13} />
              <span>Verified</span>
            </span>
          </div>
        )}
      </div>

      {/* Content */}
      <div className="p-5 flex flex-col flex-1 justify-between space-y-4">
        <div className="space-y-2">
          
          {/* IMPA & Part Number Badges */}
          <div className="flex flex-wrap items-center gap-1.5 text-xs">
            {product.impaCode && (
              <span className="px-2 py-0.5 rounded-md bg-sky-50 dark:bg-sky-950/60 text-sky-700 dark:text-sky-400 font-mono font-bold text-[11px] border border-sky-200/80 dark:border-sky-800/60">
                IMPA {product.impaCode}
              </span>
            )}
            {product.oemPartNo && (
              <span className="px-2 py-0.5 rounded-md bg-slate-100 dark:bg-slate-800 text-slate-700 dark:text-slate-300 font-mono text-[11px]">
                {product.oemPartNo}
              </span>
            )}
          </div>

          <Link href={`/listings/${product.id}`} className="block">
            <h3 className="font-extrabold text-sm sm:text-base text-slate-900 dark:text-white line-clamp-2 group-hover:text-sky-600 dark:group-hover:text-sky-400 transition-colors leading-snug">
              {product.title}
            </h3>
          </Link>
        </div>

        <div className="space-y-3 pt-3 border-t border-slate-200/80 dark:border-slate-800">
          
          {/* Price Tag */}
          <div className="flex items-baseline justify-between">
            {product.price ? (
              <div className="text-lg font-black text-slate-900 dark:text-white">
                {product.currency} {product.price}
              </div>
            ) : (
              <div className="text-xs font-bold text-sky-600 dark:text-sky-400 uppercase tracking-wider">
                RFQ Quotation
              </div>
            )}
            <span className="text-[11px] font-semibold text-slate-500 dark:text-slate-400">
              Immediate Dispatch
            </span>
          </div>

          {/* Supplier & Location Info */}
          <div className="space-y-1.5 text-xs text-slate-600 dark:text-slate-300">
            <div className="flex items-center gap-1.5">
              <Building2 size={13} className="text-sky-600 dark:text-sky-400 flex-shrink-0" />
              <span className="truncate font-medium">{product.supplierName}</span>
            </div>
            <div className="flex items-center gap-1.5">
              <MapPin size={13} className="text-sky-600 dark:text-sky-400 flex-shrink-0" />
              <span className="truncate font-medium">{product.location}</span>
            </div>
          </div>

          {/* Action Link */}
          <Link 
            href={`/listings/${product.id}`}
            className="w-full py-2.5 rounded-xl bg-sky-600/10 hover:bg-sky-600 text-sky-700 dark:text-sky-300 hover:text-white font-bold text-xs flex items-center justify-center gap-1.5 transition-colors cursor-pointer"
          >
            <span>View Specifications & RFQ</span>
            <ChevronRight size={14} />
          </Link>
        </div>

      </div>
    </motion.div>
  );
}
