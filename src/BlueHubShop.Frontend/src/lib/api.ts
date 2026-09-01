export const API_BASE_URL = process.env.NEXT_PUBLIC_API_URL || "http://localhost:5134";

export interface PagedResult<T> {
  items: T[];
  totalCount: number;
  pageNumber: number;
  pageSize: number;
}

export interface ApiProduct {
  id: number;
  title: string;
  impaCode?: string;
  issaCode?: string;
  oemPartNo?: string;
  brand?: string;
  model?: string;
  description?: string;
  category?: string;
  categoryId?: number;
  unit?: string;
  image?: string;
  price?: number;
  currency: string;
  condition: string;
  companyId?: number;
  supplierName?: string;
  supplierLocation?: string;
  isVerified: boolean;
  inStock: boolean;
  rating?: number;
  deliveryPorts: string[];
  classApprovals: string[];
}

export interface ApiCategory {
  id: number;
  name: string;
  code?: string;
  description?: string;
  image?: string;
  productCount: number;
  subcategories: { id: number; name: string; productCount: number }[];
}

export interface ApiCompany {
  id: number;
  name: string;
  companyType?: string;
  city?: string;
  country?: string;
  emailAddress?: string;
  officePhone?: string;
  webAddress?: string;
  description?: string;
  isVerified: boolean;
  rating: number;
  activeProductsCount: number;
  certifications: string[];
  mainPorts: string[];
  languages: string[];
}

export interface ApiImpaGroup {
  code: string;
  name: string;
  description: string;
  count: number;
  sampleCodes: string[];
}

export interface CreateRfqPayload {
  productId?: number;
  vesselName: string;
  imoNumber: string;
  portOfDelivery: string;
  etaDate?: string;
  quantity: number;
  notes?: string;
  contactEmail?: string;
  contactPhone?: string;
}

// Type-safe API methods with graceful fallback
export const apiClient = {
  async getProducts(params?: {
    search?: string;
    categoryId?: number;
    impaCode?: string;
    port?: string;
    condition?: string;
    verifiedOnly?: boolean;
    pageNumber?: number;
    pageSize?: number;
  }): Promise<PagedResult<ApiProduct> | null> {
    try {
      const query = new URLSearchParams();
      if (params?.search && params.search.trim()) query.append("search", params.search.trim());
      if (params?.categoryId && !isNaN(Number(params.categoryId))) query.append("categoryId", params.categoryId.toString());
      if (params?.impaCode && params.impaCode.trim()) query.append("impaCode", params.impaCode.trim());
      if (params?.port && params.port !== "All Ports" && params.port.trim()) query.append("port", params.port.trim());
      if (params?.condition && params.condition !== "All Conditions" && params.condition.trim()) query.append("condition", params.condition.trim());
      if (params?.verifiedOnly) query.append("verifiedOnly", "true");
      
      const page = params?.pageNumber && !isNaN(Number(params.pageNumber)) ? Math.max(1, Number(params.pageNumber)) : 1;
      const size = params?.pageSize && !isNaN(Number(params.pageSize)) ? Math.max(1, Number(params.pageSize)) : 24;
      query.append("pageNumber", page.toString());
      query.append("pageSize", size.toString());

      const url = `${API_BASE_URL}/api/products?${query.toString()}`;
      const res = await fetch(url, {
        cache: "no-store",
        headers: { "Content-Type": "application/json" }
      });
      if (!res.ok) {
        console.warn(`[API] ${url} responded with status: ${res.status}`);
        return null;
      }
      return await res.json();
    } catch (e) {
      console.warn("Backend API unavailable or network error:", e);
      return null;
    }
  },

  async getProductById(id: number | string): Promise<ApiProduct | null> {
    try {
      const res = await fetch(`${API_BASE_URL}/api/products/${id}`, {
        cache: "no-store",
        headers: { "Content-Type": "application/json" }
      });
      if (!res.ok) return null;
      return await res.json();
    } catch (e) {
      return null;
    }
  },

  async getCategories(): Promise<ApiCategory[] | null> {
    try {
      const res = await fetch(`${API_BASE_URL}/api/categories`, {
        cache: "no-store",
        headers: { "Content-Type": "application/json" }
      });
      if (!res.ok) return null;
      return await res.json();
    } catch (e) {
      return null;
    }
  },

  async getCompanies(params?: { search?: string; city?: string }): Promise<ApiCompany[] | null> {
    try {
      const query = new URLSearchParams();
      if (params?.search) query.append("search", params.search);
      if (params?.city) query.append("city", params.city);

      const res = await fetch(`${API_BASE_URL}/api/companies?${query.toString()}`, {
        cache: "no-store",
        headers: { "Content-Type": "application/json" }
      });
      if (!res.ok) return null;
      return await res.json();
    } catch (e) {
      return null;
    }
  },

  async getImpaCodes(search?: string): Promise<ApiImpaGroup[] | null> {
    try {
      const query = search ? `?search=${encodeURIComponent(search)}` : "";
      const res = await fetch(`${API_BASE_URL}/api/impacodes${query}`, {
        cache: "no-store",
        headers: { "Content-Type": "application/json" }
      });
      if (!res.ok) return null;
      return await res.json();
    } catch (e) {
      return null;
    }
  },

  async submitRfq(payload: CreateRfqPayload): Promise<{ success: boolean; rfqId?: number; message?: string }> {
    try {
      const res = await fetch(`${API_BASE_URL}/api/rfq`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(payload)
      });
      if (!res.ok) return { success: false, message: "Server error" };
      return await res.json();
    } catch (e) {
      // Mock success for offline mode
      return { success: true, rfqId: Math.floor(Math.random() * 10000), message: "RFQ submitted (Demo Mode)" };
    }
  }
};
