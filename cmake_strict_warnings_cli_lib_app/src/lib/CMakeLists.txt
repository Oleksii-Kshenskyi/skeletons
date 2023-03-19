set(LIB_DIR ${SRC_DIR}/lib)
set(LIB_SRC ${LIB_DIR}/test.cxx)

add_library(lib STATIC ${LIB_SRC})
set_target_properties(lib PROPERTIES CMAKE_CXX_STANDARD 20
                                     CMAKE_CXX_STANDARD_REQUIRED ON)

add_custom_command(TARGET lib POST_BUILD 
    COMMAND "${CMAKE_COMMAND}" -E copy
    "$<TARGET_FILE:lib>"
    "${CMAKE_BINARY_DIR}/$<TARGET_FILE_NAME:lib>" 
COMMENT "Copying to output directory")