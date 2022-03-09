import { apiGet, apiPost } from "./BaseProviders";

const controller = "cliente";

async function ProvidersClienteGetAll() {
    return await apiGet({controller: `${controller}/getall`});
}

async function ProvidersClienteGet(id) {
    return await apiGet({controller: `${controller}/get/?id=${id}`});
}


async function ProvidersClienteCreate(cliente) {
    return await apiPost({controller: `${controller}/post`,data: cliente});
}


export {
    ProvidersClienteGetAll, 
    ProvidersClienteGet,
    ProvidersClienteCreate
}