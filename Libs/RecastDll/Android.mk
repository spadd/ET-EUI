LOCAL_PATH := $(call my-dir)
include $(CLEAR_VARS)
LOCAL_MODULE := RecastDll
# LOCAL_SRC_FILES := ikcp.c

# LOCAL_SRC_FILES := \
# Source/*.cpp \
# ../Detour/Source/*.cpp \
# ../DetourCrowd/Source/*.cpp \
# ../DetourTileCache/Source/*.cpp \
# ../Recast/Source/*.cpp

define walk
    $(wildcard $(1)) $(foreach e, $(wildcard $(1)/*), $(call walk, $(e)))
endef


ALLFILES = $(call walk, $(LOCAL_PATH)/Source)
ALLFILES += $(call walk, $(LOCAL_PATH)/../Detour/Source)
ALLFILES += $(call walk, $(LOCAL_PATH)/../DetourCrowd/Source)
ALLFILES += $(call walk, $(LOCAL_PATH)/../DetourTileCache/Source)
ALLFILES += $(call walk, $(LOCAL_PATH)/../Recast/Source)

FILE_LIST := $(filter %.c, $(ALLFILES))
FILE_LIST += $(filter %.cpp, $(ALLFILES))
FILE_LIST += $(filter %.cc, $(ALLFILES))

LOCAL_SRC_FILES := $(FILE_LIST:$(LOCAL_PATH)/%=%)

LOCAL_C_INCLUDES := \
$(LOCAL_PATH)/Include\
$(LOCAL_PATH)/../DebugUtils/Include\
$(LOCAL_PATH)/../Detour/Include\
$(LOCAL_PATH)/../DetourCrowd/Include\
$(LOCAL_PATH)/../DetourTileCache/Include\
$(LOCAL_PATH)/../Recast/Include

include $(BUILD_SHARED_LIBRARY)