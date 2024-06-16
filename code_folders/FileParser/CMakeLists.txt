project(EosimSdkServerSolution VERSION 1.0.0 LANGUAGES CSharp)

include(CSharpUtilities)

get_filename_component(target_name ${CMAKE_CURRENT_SOURCE_DIR} NAME)

file(GLOB SRC_FILES 
	"./*.cs"
	"Implementations/*.cs"
	"Interfaces/*.cs"
	"Utils/*.cs"	
)
add_library(${target_name} SHARED ${SRC_FILES})

set_target_properties(${target_name} PROPERTIES
    VS_DOTNET_TARGET_FRAMEWORK_VERSION ${DOTNET_TARGET_FRAMEWORK}
    VS_DOTNET_SDK_VERSION ${DOTNET_SDK_VERSION}
)

# Define a custom command to ensure the .NET SDK is used
add_custom_command(TARGET ${target_name} PRE_BUILD
    COMMAND ${CMAKE_COMMAND} -E env "DOTNET_ROOT=$ENV{DOTNET_ROOT}" "DOTNET_CLI_TELEMETRY_OPTOUT=1"
    COMMAND dotnet build ${CMAKE_CURRENT_SOURCE_DIR} --framework ${DOTNET_TARGET_FRAMEWORK}
)
