module.exports = {
    content: ["./Views/**/*.{cshtml,html,js}", "./wwwroot/**/*.js"],
    theme: {
        extend: {
            fontFamily: {
                ascii: ['"Courier New"', 'Courier', 'monospace'],
            },
            colors: {
                // Kawaii pastels extension if needed outside of daisyui theme
                'kawaii-pink': '#ffb1c1',
            }
        },
    },
    plugins: [require("daisyui")],
    daisyui: {
        themes: [
            {
                valentine: {
                    "primary": "#fc5a80ff", // Soft Pink
                    "secondary": "#02e6ffff", // Pale Cyan
                    "accent": "#ffd710ff", // Pastel Yellow
                    "neutral": "#f3f4f6", // Light Gray
                    "base-100": "#fff5f7", // Very light pink (almost white)
                    "base-200": "#ffe4e6", // Brighter Pink for Sidebar
                    "base-content": "#4c0519", // Deep violet-brown for text
                    "info": "#0077ffff",
                    "success": "#86efac",
                    "warning": "#fde047",
                    "error": "#fca5a5",
                    "--rounded-box": "0.3rem", // Slightly Round
                    "--rounded-btn": "0.3rem", // Slightly Round
                    "--rounded-badge": "0.5rem", // Slightly Round
                },
            },
            "synthwave"
        ],
    },
}
