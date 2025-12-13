import daisyui from "daisyui";

export default {
    content: ["./Views/**/*.{cshtml,html,js}", "./wwwroot/**/*.js"],
    theme: {
        extend: {
            fontFamily: {
                ascii: ['"Courier New"', 'Courier', 'monospace'],
            },
            colors: {
                'kawaii-pink': '#ffb1c1',
            }
        },
    },
    plugins: [daisyui],
    daisyui: {
        themes: [
            {
                valentine: {
                    "primary": "#fc5a80ff",
                    "secondary": "#02e6ffff",
                    "accent": "#ffd710ff",
                    "neutral": "#f3f4f6",
                    "base-100": "#fff5f7",
                    "base-200": "#ffe4e6",
                    "base-content": "#4c0519",
                    "info": "#0077ffff",
                    "success": "#86efac",
                    "warning": "#fde047",
                    "error": "#fca5a5",
                    "--rounded-box": "0.3rem",
                    "--rounded-btn": "0.3rem",
                    "--rounded-badge": "0.5rem"
                },
            },
            "synthwave"
        ],
    },
}
