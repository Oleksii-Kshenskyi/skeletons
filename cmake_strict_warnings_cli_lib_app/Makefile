c: ./build/
	rm -rf build
cm: ./CMakeLists.txt
	mkdir -p build && cd build && cmake .. -G "Unix Makefiles"
b: ./build/
	cd build && make -j16
r: build/todo
	build/todo