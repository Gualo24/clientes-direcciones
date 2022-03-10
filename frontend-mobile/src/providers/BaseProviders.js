import axios from "axios";
import Response from "../utils/Response";

const BaseUrl = "https://clientes-direcciones.azurewebsites.net/";

async function apiGet({ controller }) {
    try {
        const configuration = {
            headers: {
                "Content-Type": "application/json",
            },
        };
        const rst = await axios.get(`${BaseUrl}api/${controller}`, configuration);
        if (rst.status === 200 || rst.status === 201 || rst.status === 204) {
            return new Response(true, null, rst.data);
        } else {
            return new Response(false, rst.data, null);
        }

    } catch (error) {
        return Es401(error)
    }
}

async function apiPost({ controller, data }) {
    try {
        const configuration = {
            headers: {
                "Content-Type": "application/json",
            },
        };
        const rst = await axios.post(`${BaseUrl}api/${controller}`, data, configuration);
        if (rst.status === 200 || rst.status === 201 || rst.status === 204) {
            return new Response(true, null, rst.data);
        } else {
            return new Response(false, rst.data, null);
        }
    } catch (error) {
        return Es401(error)
    }
}


async function apiPut({ controller, data }) {
    try {
        const configuration = {
            headers: {
                "Content-Type": "application/json",
            },
        };
        const rst = await axios.put(`${BaseUrl}api/${controller}`, data, configuration);
        if (rst.status === 200 || rst.status === 201 || rst.status === 204) {
            return new Response(true, null, rst.data);
        } else {
            return new Response(false, rst.data, null);
        }
    } catch (error) {
        return Es401(error)
    }
}

async function apiDelete({ controller }) {
    try {
        const configuration = {
            headers: {
                "Content-Type": "application/json",
            },
        };
        const rst = await axios.delete(`${BaseUrl}api/${controller}`, configuration);
        if (rst.status === 200 || rst.status === 201 || rst.status === 204) {
            return new Response(true, null, rst.data);
        } else {
            return new Response(false, rst.data, null);
        }
    } catch (error) {
        return Es401(error)
    }
}

function Es401(ex) {
    const err = { ...ex };
    if (err.response && err.response.status === 401) {
        return new Response(false, "Su session a caducado", null)
    } else {
        return new Response(false, (err.response.data) ?? "Ocurrio un error con la peticion" , null)
    }
}

export { apiGet, apiPost, apiPut, apiDelete };