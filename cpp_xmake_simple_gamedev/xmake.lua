-- mygame: genetic natural selection simulation
set_project("mygame")
set_version("0.0.1")
set_languages("c++23")

-- Use clang everywhere. On Windows this will pick clang++; if you later decide
-- you want the MSVC-ABI flavor, switch this to "clang-cl".
set_toolchains("clang")

-- Sensible warnings and debug info for the default build.
set_warnings("all", "extra", "pedantic")
add_cxflags("-Wno-unused-parameter", {tools = {"clang", "gcc"}})

-- Build modes: `xmake f -m debug` or `xmake f -m release`
add_rules("mode.debug", "mode.release")

-- Dependencies. xmake will fetch and build these on first configure.
add_requires("raylib 5.5.x", {configs = {shared = false}})
add_requires("entt 3.14.x")

target("mygame")
    set_kind("binary")
    add_files("src/*.cpp")
    add_packages("raylib", "entt")

    -- On macOS raylib needs these frameworks; xmake's raylib package
    -- usually pulls them automatically, but being explicit is harmless.
    if is_plat("macosx") then
        add_frameworks("Cocoa", "IOKit", "CoreVideo", "OpenGL")
    end

    -- Regenerate compile_commands.json into the project root so clangd
    -- always sees current flags.
    -- NOTE: we use the built-in rule instead of shelling out to
    -- `xmake project -k compile_commands` in after_build, because that
    -- spawns a child xmake that deadlocks on the project lock.
    add_rules("plugin.compile_commands.autoupdate", {outputdir = "."})
