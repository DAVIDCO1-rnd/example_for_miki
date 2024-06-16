cmake_minimum_required(VERSION 3.12)
project(examples_for_miki VERSION 1.0.0)

if(CMAKE_SIZEOF_VOID_P EQUAL 8)
	set(PROJECT_ARCH "x64")
else(CMAKE_SIZEOF_VOID_P EQUAL 4)
	set(PROJECT_ARCH "x86")
endif()

set(BINARY_DIR_OUTPUT ${CMAKE_BINARY_DIR}/bin/${PROJECT_ARCH}/$<CONFIG>)
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY ${BINARY_DIR_OUTPUT})
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY ${BINARY_DIR_OUTPUT})

# Set the .NET SDK version and target framework
set(DOTNET_SDK_VERSION "6.0")
set(DOTNET_TARGET_FRAMEWORK "net6.0")

set(CMAKE_CSharp_FLAGS_RELEASE "/debug:full /optimize-") # Disable code optimization in Release mode


add_subdirectory("code_folders")
