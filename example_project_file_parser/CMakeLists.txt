project(EosimSdkServerSolution VERSION 1.0.0 LANGUAGES CSharp)

include(CSharpUtilities)

get_filename_component(target_name ${CMAKE_CURRENT_SOURCE_DIR} NAME)

file(GLOB SRC_FILES "*.*")
add_executable(${target_name} ${SRC_FILES})
#SET_PROPERTY(TARGET ${target_name} PROPERTY VS_GLOBAL_EnableUnmanagedDebugging "true")

set_property(TARGET ${target_name} PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION ${DOTNET_TARGET_FRAMEWORK})

#target_compile_options(${target_name} PUBLIC "/unsafe")

set_property(TARGET ${target_name} PROPERTY VS_DOTNET_REFERENCES 
"Microsoft.CSharp;
System;
System.Core;
System.Drawing;
System.Data;
System.Data.DataSetExtensions;
System.Runtime.Serialization;
System.XML;
System.Xml.Linq;
WindowsBase
")

set_property(TARGET ${target_name} PROPERTY VS_DOTNET_REFERENCE_FileParser "${CMAKE_SOURCE_DIR}/net6.0/FileParser.dll")

set_target_properties(${target_name} PROPERTIES FOLDER practice_projects)