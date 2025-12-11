module.exports = {
    content: ["./Views/**/*.{cshtml,html,js}", "./wwwroot/**/*.js"],
    theme: {
        extend: {
            fontFamily: {
                ascii: ['"Ascii Art Font"', 'monospace'],
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
                kawaii: {
                    "primary": "#ffb1c1", // Pink
                    "secondary": "#9adbe8", // Cyan-ish
                    "accent": "#ffe484", // Yellow
                    "neutral": "#f3f4f6", // Light Gray
                    "base-100": "#fff0f5", // Lavender Blush (Pastel Pink)
                    "info": "#93c5fd",
                    "success": "#86efac",
                    "warning": "#fde047",
                    "error": "#fca5a5",
                    "--rounded-box": "0rem", // Square
                    "--rounded-btn": "0rem", // Square
                    "--rounded-badge": "0rem", // Square
                },
            },
            "synthwave"
        ],
    },
}
