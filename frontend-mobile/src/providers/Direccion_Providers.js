import { apiDelete, apiGet, apiPost } from "./BaseProviders";

const controller = "direccion";

async function ProvidersDireccionGetProvincias() {
    return await apiGet({ controller: `${controller}/GetProvincias` })
}

async function ProvidersDireccionGetMunicipios(id) {
    return await apiGet({ controller: `${controller}/GetMunicipios/?id=${id}` })
}

async function ProvidersDireccionCreate(direccion) {
    return await apiPost({ controller: `${controller}/post`, data: direccion })
}

async function ProvidersDireccionDelete(id) {
    return await apiDelete({ controller: `${controller}/delete/?id=${id}` })
}

export {
    ProvidersDireccionGetProvincias, 
    ProvidersDireccionGetMunicipios,
    ProvidersDireccionCreate,
    ProvidersDireccionDelete
}