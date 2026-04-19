#include "raylib.h"
#include <cstdint>

namespace mygame::constants {
    inline constexpr Color BACKGROUND_COLOR = Color {
        .r=0x22,
        .g=0x22,
        .b=0x22,
        .a=0xff
    };

    inline constexpr uint32_t TARGET_FPS = 30;
    inline constexpr uint16_t CELL_SIZE = 30;
};