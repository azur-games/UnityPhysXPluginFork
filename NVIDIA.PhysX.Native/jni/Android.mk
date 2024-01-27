# Copyright 2015 Google Inc. All rights reserved.
#
# Licensed under the Apache License, Version 2.0 (the "License");

LOCAL_PATH := $(call my-dir)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysX_static_64
LOCAL_SRC_FILES         := libPhysX_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysXCharacterKinematic_static_64
LOCAL_SRC_FILES         := libPhysXCharacterKinematic_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysXCommon_static_64
LOCAL_SRC_FILES         := libPhysXCommon_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysXCooking_static_64
LOCAL_SRC_FILES         := libPhysXCooking_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysXExtensions_static_64
LOCAL_SRC_FILES         := libPhysXExtensions_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysXFoundation_static_64
LOCAL_SRC_FILES         := libPhysXFoundation_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysXPvdSDK_static_64
LOCAL_SRC_FILES         := libPhysXPvdSDK_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

# hatch library
include $(CLEAR_VARS)
LOCAL_MODULE            := PhysXVehicle_static_64
LOCAL_SRC_FILES         := libPhysXVehicle_static_64.a
# The header files should be located in the following dir relative to jni/ dir
LOCAL_EXPORT_C_INCLUDES := 	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/
include $(PREBUILT_STATIC_LIBRARY)

ifeq ($(TARGET_ARCH_ABI),$(filter $(TARGET_ARCH_ABI), armeabi-v7a))
    LOCAL_CFLAGS := -ANDROID=1
endif
include $(CLEAR_VARS)

LOCAL_SHORT_COMMANDS := true

LOCAL_C_INCLUDES := \
	../ \
    ../Header/ \
	../Helpers/ \
	../Wrapper/ \
	D:/Projects/PhysX4.1/physx/include/ \
	D:/Projects/PhysX4.1/physx/install/vc15win64/PxShared/include/

LOCAL_MODULE := NVIDIA.PhysX.Native
LOCAL_CFLAGS := $(LOCAL_C_INCLUDES:%=-I%) -fexceptions
LOCAL_LDLIBS := -L$(SYSROOT)/usr/lib -ldl -lm -llog

LOCAL_SRC_FILES := \
../Helpers/Helpers.cpp \
../Wrapper/NativeCSHARP_wrap.cxx

LOCAL_STATIC_LIBRARIES := \
PhysX_static_64 \
PhysXCharacterKinematic_static_64 \
PhysXCommon_static_64 \
PhysXCooking_static_64 \
PhysXExtensions_static_64 \
PhysXFoundation_static_64 \
PhysXPvdSDK_static_64 \
PhysXVehicle_static_64

include $(BUILD_SHARED_LIBRARY)
