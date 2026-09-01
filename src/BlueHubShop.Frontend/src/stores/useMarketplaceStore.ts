import { create } from "zustand";
import { apiClient, ApiProduct, ApiCategory, ApiCompany, ApiImpaGroup } from "@/lib/api";

interface MarketplaceState {
  products: ApiProduct[];
  totalProducts: number;
  categories: ApiCategory[];
  companies: ApiCompany[];
  impaGroups: ApiImpaGroup[];
  isLoading: boolean;
  searchQuery: string;
  selectedPort: string;
  selectedCondition: string;
  selectedClass: string[];
  verifiedOnly: boolean;
  inStockOnly: boolean;

  setSearchQuery: (query: string) => void;
  setSelectedPort: (port: string) => void;
  setSelectedCondition: (condition: string) => void;
  toggleSelectedClass: (className: string) => void;
  setVerifiedOnly: (verified: boolean) => void;
  setInStockOnly: (inStock: boolean) => void;
  resetFilters: () => void;

  fetchProducts: () => Promise<void>;
  fetchCategories: () => Promise<void>;
  fetchCompanies: () => Promise<void>;
  fetchImpaCodes: () => Promise<void>;
}

export const useMarketplaceStore = create<MarketplaceState>((set, get) => ({
  products: [],
  totalProducts: 0,
  categories: [],
  companies: [],
  impaGroups: [],
  isLoading: false,
  searchQuery: "",
  selectedPort: "All Ports",
  selectedCondition: "All Conditions",
  selectedClass: [],
  verifiedOnly: false,
  inStockOnly: false,

  setSearchQuery: (query) => set({ searchQuery: query }),
  setSelectedPort: (port) => set({ selectedPort: port }),
  setSelectedCondition: (condition) => set({ selectedCondition: condition }),
  toggleSelectedClass: (className) => {
    const current = get().selectedClass;
    set({
      selectedClass: current.includes(className)
        ? current.filter(c => c !== className)
        : [...current, className]
    });
  },
  setVerifiedOnly: (verified) => set({ verifiedOnly: verified }),
  setInStockOnly: (inStock) => set({ inStockOnly: inStock }),
  resetFilters: () => set({
    searchQuery: "",
    selectedPort: "All Ports",
    selectedCondition: "All Conditions",
    selectedClass: [],
    verifiedOnly: false,
    inStockOnly: false
  }),

  fetchProducts: async () => {
    set({ isLoading: true });
    const { searchQuery, selectedPort, selectedCondition, verifiedOnly } = get();
    const result = await apiClient.getProducts({
      search: searchQuery || undefined,
      port: selectedPort,
      condition: selectedCondition,
      verifiedOnly: verifiedOnly ? true : undefined
    });

    if (result && result.items.length > 0) {
      set({ products: result.items, totalProducts: result.totalCount, isLoading: false });
    } else {
      set({ isLoading: false });
    }
  },

  fetchCategories: async () => {
    const result = await apiClient.getCategories();
    if (result && result.length > 0) {
      set({ categories: result });
    }
  },

  fetchCompanies: async () => {
    const result = await apiClient.getCompanies();
    if (result && result.length > 0) {
      set({ companies: result });
    }
  },

  fetchImpaCodes: async () => {
    const result = await apiClient.getImpaCodes();
    if (result && result.length > 0) {
      set({ impaGroups: result });
    }
  }
}));
