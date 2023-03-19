cmake_minimum_required(VERSION 3.20)

project(todo)

set(SRC_DIR ${CMAKE_SOURCE_DIR}/src)
set(CMAKE_MODULES ${CMAKE_SOURCE_DIR}/cmake/modules)
include(${CMAKE_MODULES}/warnings.cmake)

add_compile_options(${BT_WARNINGS_STRICT})

include_directories(${SRC_DIR})

add_subdirectory(${SRC_DIR})

