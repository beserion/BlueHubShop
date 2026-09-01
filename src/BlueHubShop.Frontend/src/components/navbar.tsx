"use client";

import * as React from "react";
import Link from "next/link";
import { useTheme } from "next-themes";
import { flushSync } from "react-dom";
import { motion, AnimatePresence } from "framer-motion";
import { Moon, Sun, Search, Ship, Menu, User, Sparkles } from "lucide-react";

export function Navbar() {
  const { setTheme, resolvedTheme } = useTheme();
  const [mounted, setMounted] = React.useState(false);
  const [isScrolled, setIsScrolled] = React.useState(false);

  React.useEffect(() => {
    setMounted(true);
    const handleScroll = () => {
      setIsScrolled(window.scrollY > 20);
    };
    window.addEventListener("scroll", handleScroll);
    return () => window.removeEventListener("scroll", handleScroll);
  }, []);

  const isDark = mounted && resolvedTheme === "dark";

  // DPI-Independent Percentage-Based Circular Wave from Exact Cursor
  const toggleThemeWithRipple = (event: React.MouseEvent<HTMLButtonElement>) => {
    const isCurrentlyDark = document.documentElement.classList.contains("dark");
    const nextTheme = isCurrentlyDark ? "light" : "dark";

    // Direct cursor coordinates at the exact pixel of the mouse click
    const clientX = event.clientX ?? (event.nativeEvent as MouseEvent).clientX;
    const clientY = event.clientY ?? (event.nativeEvent as MouseEvent).clientY;

    // Convert to percentage of viewport to be 100% DPI and resolution independent
    const xPercent = Number(((clientX / window.innerWidth) * 100).toFixed(2));
    const yPercent = Number(((clientY / window.innerHeight) * 100).toFixed(2));

    // Massive radius (minimum 3500px) ensuring 100% full viewport coverage without stopping early
    const maxViewportDistance = Math.hypot(
      Math.max(clientX, window.innerWidth - clientX),
      Math.max(clientY, window.innerHeight - clientY)
    );
    const endRadius = Math.max(Math.ceil(maxViewportDistance * 1.5), 3500);

    // Fallback if browser doesn't support View Transitions API
    if (typeof document === "undefined" || !("startViewTransition" in document)) {
      setTheme(nextTheme);
      return;
    }

    try {
      // @ts-ignore
      const transition = document.startViewTransition(() => {
        // Synchronously flush DOM update via React flushSync
        flushSync(() => {
          if (nextTheme === "dark") {
            document.documentElement.classList.add("dark");
          } else {
            document.documentElement.classList.remove("dark");
          }
          setTheme(nextTheme);
        });
      });

      transition.ready
        .then(() => {
          // Animate the circle expanding outward from the exact percentage position of the cursor
          document.documentElement.animate(
            {
              clipPath: [
                `circle(0px at ${xPercent}% ${yPercent}%)`,
                `circle(${endRadius}px at ${xPercent}% ${yPercent}%)`
              ]
            },
            {
              duration: 750,
              easing: "cubic-bezier(0.25, 1, 0.5, 1)",
              pseudoElement: "::view-transition-new(root)"
            }
          );
        })
        .catch(() => {});
    } catch {
      setTheme(nextTheme);
    }
  };

  return (
    <motion.header
      initial={{ y: -100 }}
      animate={{ y: 0 }}
      transition={{ duration: 0.5, ease: "easeOut" }}
      className={`fixed top-0 w-full z-50 transition-all duration-300 ${
        isScrolled ? "glass-nav py-3.5" : "bg-transparent py-5"
      }`}
    >
      <div className="container mx-auto px-6 flex items-center justify-between">
        
        {/* Brand Logo */}
        <Link href="/" className="flex items-center gap-2.5 group">
          <div className="w-10 h-10 rounded-2xl bg-gradient-to-tr from-sky-600 to-blue-700 dark:from-sky-400 dark:to-cyan-300 flex items-center justify-center text-white dark:text-slate-950 shadow-md group-hover:scale-105 transition-transform">
            <Ship size={22} className="stroke-[2.5]" />
          </div>
          <span className="text-xl font-black tracking-tight text-slate-900 dark:text-white">
            BlueHub<span className="text-sky-600 dark:text-sky-400">Shop</span>
          </span>
        </Link>

        {/* Desktop Navigation Links */}
        <nav className="hidden md:flex items-center gap-8">
          <Link 
            href="/listings" 
            className="text-sm font-semibold text-slate-700 dark:text-slate-200 hover:text-sky-600 dark:hover:text-sky-400 transition-colors"
          >
            All Listings
          </Link>
          <Link 
            href="/categories" 
            className="text-sm font-semibold text-slate-700 dark:text-slate-200 hover:text-sky-600 dark:hover:text-sky-400 transition-colors"
          >
            Categories
          </Link>
          <Link 
            href="/impa-codes" 
            className="text-sm font-semibold text-slate-700 dark:text-slate-200 hover:text-sky-600 dark:hover:text-sky-400 transition-colors"
          >
            IMPA Guide
          </Link>
          <Link 
            href="/stores" 
            className="text-sm font-semibold text-slate-700 dark:text-slate-200 hover:text-sky-600 dark:hover:text-sky-400 transition-colors"
          >
            Verified Chandlers
          </Link>
        </nav>

        {/* Actions Bar */}
        <div className="flex items-center gap-3">
          
          <Link 
            href="/listings" 
            className="hidden md:flex items-center gap-2 px-4 py-2 rounded-full bg-white/90 dark:bg-slate-900/90 backdrop-blur-md text-xs font-semibold text-slate-600 dark:text-slate-300 hover:text-sky-600 dark:hover:text-sky-400 border border-slate-200/90 dark:border-white/10 shadow-sm"
          >
            <Search size={15} className="text-sky-600 dark:text-sky-400" />
            <span>Quick IMPA Search...</span>
          </Link>

          {/* Animated Smooth Circular Ripple Theme Toggle */}
          <motion.button
            whileHover={{ scale: 1.08 }}
            whileTap={{ scale: 0.92 }}
            onClick={toggleThemeWithRipple}
            className="p-2.5 rounded-2xl bg-white/90 dark:bg-slate-900/90 backdrop-blur-md text-slate-700 dark:text-slate-200 hover:text-sky-600 dark:hover:text-sky-400 border border-slate-200/90 dark:border-white/10 shadow-sm relative overflow-hidden flex items-center justify-center cursor-pointer"
            aria-label="Toggle Theme with Circular Wave"
            title={isDark ? "Switch to High-Contrast Light Mode" : "Switch to Dark Mode"}
          >
            <AnimatePresence mode="wait" initial={false}>
              {mounted && (
                <motion.div
                  key={isDark ? "dark" : "light"}
                  initial={{ y: -15, opacity: 0, rotate: -90 }}
                  animate={{ y: 0, opacity: 1, rotate: 0 }}
                  exit={{ y: 15, opacity: 0, rotate: 90 }}
                  transition={{ duration: 0.25, ease: "easeOut" }}
                >
                  {isDark ? (
                    <Sun className="h-4 w-4 text-amber-400" />
                  ) : (
                    <Moon className="h-4 w-4 text-sky-600" />
                  )}
                </motion.div>
              )}
            </AnimatePresence>
          </motion.button>

          {/* User Account / RFQ Link */}
          <Link 
            href="/listings" 
            className="p-2.5 rounded-2xl bg-white/90 dark:bg-slate-900/90 backdrop-blur-md text-slate-700 dark:text-slate-200 hover:text-sky-600 dark:hover:text-sky-400 border border-slate-200/90 dark:border-white/10 shadow-sm transition-colors cursor-pointer"
            title="Account & RFQ Center"
          >
            <User size={18} />
          </Link>

        </div>
      </div>
    </motion.header>
  );
}
