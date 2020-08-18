import 'react-app-polyfill/ie9';
import 'react-app-polyfill/stable';

import React from 'react';
import ReactDOM from 'react-dom';
import { HelloWorld } from './Components/HelloWorld';

ReactDOM.render(<HelloWorld name="Simon" />, document.getElementById('hello-world'));