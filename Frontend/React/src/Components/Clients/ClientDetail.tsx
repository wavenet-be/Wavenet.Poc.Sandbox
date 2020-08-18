import React from 'react';

interface ClientDetailProps
{
    client: any;
}

export const ClientDetail = (props: ClientDetailProps) =>
{
    return <>{props.client && <div className="client-detail-panel">
        <h4>Détails de {props.client.name}</h4>
        <h5>Adresse :</h5>
        {props.client.address.street}<br/>
        {props.client.address.zipCode} {props.client.address.city}<br/>
        {props.client.address.country}
    </div>}</>;
};