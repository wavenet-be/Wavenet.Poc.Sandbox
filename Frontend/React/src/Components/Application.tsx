import React from 'react';
import { TopBar } from './Navigation/TopBar';
import { Clients } from '../Containers/Clients';

export const Application = () => {
    return <div className="app-root">
        <TopBar />
        <Clients />
    </div>
}