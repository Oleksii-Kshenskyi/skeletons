set(CLI_DIR ${SRC_DIR}/cli)
set(CLI_SRC ${CLI_DIR}/main.cxx)

add_executable(todo ${CLI_SRC})
set_target_properties(todo PROPERTIES CMAKE_CXX_STANDARD 20
                                      CMAKE_CXX_STANDARD_REQUIRED ON)
target_link_libraries(todo lib)

set_target_properties(todo PROPERTIES
    RUNTIME_OUTPUT_DIRECTORY_DEBUG ${CMAKE_BINARY_DIR}
    RUNTIME_OUTPUT_DIRECTORY_RELEASE ${CMAKE_BINARY_DIR}
)

add_custom_command(TARGET todo POST_BUILD 
    COMMAND "${CMAKE_COMMAND}" -E copy
    "$<TARGET_FILE:todo>"
    "${CMAKE_BINARY_DIR}/$<TARGET_FILE_NAME:todo>" 
COMMENT "Copying to output directory")