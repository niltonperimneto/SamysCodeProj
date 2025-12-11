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
                    "base-100": "#ffffff", // White
                    "info": "#93c5fd",
                    "success": "#86efac",
                    "warning": "#fde047",
                    "error": "#fca5a5",
                    "--rounded-box": "1rem",
                    "--rounded-btn": "1.9rem",
                    "--rounded-badge": "1.9rem",
                },
            },
        ],
    },
}
