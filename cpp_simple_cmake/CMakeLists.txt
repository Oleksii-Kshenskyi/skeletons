cmake_minimum_required(VERSION 3.24.0)

project(CMakeSkel)

set(SRC "./src")

include_directories(${SRC})

add_executable(cmakeskel ${SRC}/main.cxx)
set_target_properties(cmakeskel 
                        PROPERTIES
                            CXX_STANDARD 20
                            CXX_STANDARD_REQUIRED On)