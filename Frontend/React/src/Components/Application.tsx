import React from 'react';
import { TopBar } from './Navigation/TopBar';
import { ClientList } from './Clients/ClientList';

export const Application = () => {
    return <div className="app-root">
        <TopBar />
        <div className="container">
            <ClientList />
        </div>
    </div>
}