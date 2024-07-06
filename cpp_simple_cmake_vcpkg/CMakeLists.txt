# Add vcpkg toolchain
set(CMAKE_TOOLCHAIN_FILE "C:/Users/oleks/gitproj/smol_sim/vcpkg/scripts/buildsystems/vcpkg.cmake")

cmake_minimum_required(VERSION 3.26)
project(fmt_test)

set(SRC_DIR ${CMAKE_SOURCE_DIR}/src)

# Set the C++ standard
set(CMAKE_CXX_STANDARD 20)
set(CMAKE_CXX_STANDARD_REQUIRED True)

# Find and link fmt
find_package(fmt CONFIG REQUIRED)
add_executable(fmt_test ${SRC_DIR}/main.cxx)
target_link_libraries(fmt_test PRIVATE fmt::fmt)