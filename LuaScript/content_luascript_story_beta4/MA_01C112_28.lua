-- このluaスクリプトは、MA_01C112_28.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
turn_lookat(Actor001,Actor002, 0)
turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★マーリン★★:どこまでお話ししたでしょうか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280002")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:そう――王家の血は穢れていると
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280003")

	change_face(Actor002,"Normal")

	--★★マーリン★★:アーサー様は愛している<br>王として、この国に生きる民を。若者を
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280004")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:だからきっと、許せないのです<br>伝承に縛られ、自己犠牲を強いる世界を
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280005")


	--★★マーリン★★:そしてなにより、己の体を巡る血を
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ルーシャスやモルドレッドに言わせれば<br>甘っちょろい奴だって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_280007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力

	--★★マーリン★★:…そうかもしれませんね
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280008")

	change_face(Actor002,"Normal")

	--★★マーリン★★:若者は戦地になど行かずに<br>年相応の生活を――青春を謳歌すべきだと
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280009")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定2")
-- ▲直接出力

	--★★マーリン★★:そんなことを仰るくらいですから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280010")

	open_select_window_tag(Actor001,"Normal","MA_01C112_280011","MA_01C112_280012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーの考えは素敵だと思う<br>本当にそうできたら、どれだけ幸せか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_280014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マーリン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:はい、私も同じ気持ちです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280015")

-- ▼直接出力
 --PlayPartVoice("マーリン", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:あの方はお優しい<br>お優しすぎたからこそ…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういうアーサーは…<br>青春を謳歌できたんだろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_280018")

	change_face(Actor002,"Sad")

	--★★マーリン★★:あの方の人生はバルバロイとの戦いで始まり<br>今もなおバルバロイとともにあります
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280019")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:私の前で弱音を吐いたことなどありませんが<br>心の奥底ではきっと…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280020")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★マーリン★★:でも、買い食いしてるあの方は<br>いつもとても楽しそうでした
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280022")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マーリン★★:それだけが私の救いです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.7)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マーリン★★:…これ以上は止めましょう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280024")

	change_face(Actor002,"Sad")

	--★★マーリン★★:あの方もそれを望まないでしょうから?
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C112_280025")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
