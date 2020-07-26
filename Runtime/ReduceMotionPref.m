#if __cplusplus
extern "C" {
#endif
	
	bool FPRMP_ReduceMotion() {
		return UIAccessibilityIsReduceMotionEnabled();
	}
	
#if __cplusplus
}
#endif
