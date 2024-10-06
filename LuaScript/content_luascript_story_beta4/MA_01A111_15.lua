-- このluaスクリプトは、MA_01A111_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_010,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_010)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
lookat_weight(Actor001,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002,0.5,0.1,0.85,0.2)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
-- ▲直接出力
-- ▼直接出力
set_pos(GEO_TRAYB09,{0.369,0.815,-6.477})
-- ▲直接出力
-- ▼直接出力
mob01 = get_object("m050")
mob02 = get_object("m051")
set_pos(mob01,{0,-20,0})
set_pos(mob02,{0,-20,0})
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera003
-- ▲直接出力
-- ▼直接出力
LavCam = create_camera()
load_camera_anim(LavCam , CameraAssetBundleName110122_01, "P50_Cam")
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-2.87, 2.5, -1.14,   12.3, 155, 0,   22})
-- ▲直接出力
-- ▼直接出力
RndCamera001 = RndCamera004
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:よォ、ノワール…<br>メシがウマくなる話じゃねーけどさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150002")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:例えば俺の知り合いにAとBってヤツがいてさ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150003")


	--★★ガウェイン★★:AとBと俺の3人でつるむときは<br>まぁまぁ話せるケド
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:Aが抜けた途端、あんまハズまねー相手B…<br>みたいなってヤツいたりしねえか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150005")

	open_select_window_tag(Actor001,"Normal","MA_01A111_150007","MA_01A111_150008","MA_01A111_150009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いるといえばいるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_150011")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:いるっちゃあいるよな、よな？<br>ヤな奴じゃねーんだよＢってのはさ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150012")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:ただなんていうかさ、マッチしねえっていうか<br>Ｂとは仲良くなりてえと思ってんだけどずっと！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いないなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_150015")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:お前交友関係広いもんな<br>俺もダチが少ないほうじゃねえけど
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150016")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:なんか盗賊の知り合いもいるって聞いたぜ<br>今度紹介しろよ、ヤバい話聞けそう
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150017")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:相手によるかなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_150019")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:Ｂの場合だよＢの場合
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150020")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:Ｂがわからないって<br>Ｂの人柄がわからないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_150021")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(LavCam)
set_enable_auto_lookat(Actor003,true)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1.0)
lookat_weight(Actor001,0.7,0.05,0.9,0.2)
lookat_weight(Actor002,0.7,0.05,0.9,0.2)
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "挨拶")
-- ▲直接出力

	--★★ラヴェイン★★:『Ｂ』とはひょっとして<br>私のことですか？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A111_150023")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:…き、聞こえてたのかよ、生徒会長
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150025")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定")
-- ▲直接出力

	--★★ラヴェイン★★:聞き上手なもので
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A111_150027")

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:聞き上手ってそういう意味じゃないような…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_150028")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:ご、誤解すんなよ生徒会長
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150029")

	change_face(Actor002,"Sad")

	--★★ガウェイン★★:俺は「どうやったらＢと仲良くできるか」を<br>今から相談しようとしてたんだからな…！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150030")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "肯定2")
-- ▲直接出力

	--★★ラヴェイン★★:『ラヴェイン』と気軽にお呼びください<br>Ｂも貴方がたと仲良くなりたいようですから
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A111_150031")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
set_pos(Actor003,CharaPos110122_01_005)
-- ▲直接出力
-- ▼直接出力
set_pos(GEO_TRAYB09,{-15,0.0,1.25})
setup_template_moveobj_110122_01(5,true)
-- ▲直接出力
-- ▼直接出力
turn(Actor003,0,281.181, 0,0)
 lookat_weight_default(Actor001)
 lookat_weight_default(Actor002)
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
 setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ラヴェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ラヴェイン★★:さあ。なにから話せば<br>食事が美味しくなりますか？
	Talk(Actor003,"CHRNAME_LOVEIN","speech","L","MA_01A111_150033")

-- ▼直接出力
on_camera(Camera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力

	--★★ガウェイン★★:…う～ん、きマズい
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","MA_01A111_150034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
RndCamera001 = RndCamera003
load_camera_anim_preload(LavCam , CameraAssetBundleName110122_01, "P50_Cam")
RndCamera001 = RndCamera004
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101031","001","101031001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
