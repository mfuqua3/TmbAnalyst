import * as $ from "jquery";
import * as jquery from "jquery";
declare global {
    interface Window {
        $: any;
        jquery: any;
        bootstrap: any;
    }
}
window.$ = $;
window.jquery = jquery;
import '@popperjs/core/lib/popper.js';
import "./index.css";
import * as bootstrap from "bootstrap";
window.bootstrap = bootstrap;