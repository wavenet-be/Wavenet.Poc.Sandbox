import { AjaxService } from './AjaxService';

export const ClientService =
{
    getClients()
    {
        return AjaxService.get<any[]>('https://localhost:44350/api/client/list');
    },

    getClient(clientId: number)
    {
        return AjaxService.get<any>('https://localhost:44350/api/client/' + clientId);
    }
}