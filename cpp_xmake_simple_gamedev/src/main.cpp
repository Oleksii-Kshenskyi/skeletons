#include <entt/entt.hpp>
#include <raylib.h>

#include "constants.hpp"

namespace cnst = mygame::constants;

int main() {
    SetConfigFlags(FLAG_WINDOW_RESIZABLE | FLAG_WINDOW_MAXIMIZED);
    InitWindow(0, 0, "mygame");
    ClearWindowState(FLAG_WINDOW_RESIZABLE);
    SetTargetFPS(cnst::TARGET_FPS);

    entt::registry registry;

    while (!WindowShouldClose()) {
        BeginDrawing();
            ClearBackground(cnst::BACKGROUND_COLOR);
            DrawFPS(10, 10);
        EndDrawing();
    }

    CloseWindow();
    return 0;
}