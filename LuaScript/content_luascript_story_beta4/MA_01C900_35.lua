-- このluaスクリプトは、MA_01C900_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111151_02","111151_02_h")
Include("content_adv_advsmall_111151_02","Template111151_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111151_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_525_01_StdController","to Std_Loop",CameraAssetBundleName111151_02,CameraPos111151_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111151_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_513_01_StdController","to Std_Loop",CameraAssetBundleName111151_02,CameraPos111151_02_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111151_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName111151_02,CameraPos111151_02_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos111151_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111151_02,CameraPos111151_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos111151_02_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111151_02,CameraPos111151_02_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos111151_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_SleepController","to Std_Loop",CameraAssetBundleName111151_02,CameraPos111151_02_001)
	InitializeTemplateRandomCamera111151_02()
	InitializeTemplate111151_02()
-- ▼直接出力
force_eyesync(Actor006,"Close")
reserve_eyesync(Actor006,"Close")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
 --arufa = 0.035
--setup_small_camera_resetting(Actor006,{CharaPos110141_02_001[1],CharaPos110141_02_001[2]+arufa,CharaPos110141_02_001[3],CharaPos110141_02_001[4]},CameraPos001)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor004,{1.01, 0, 0.917})
-- ▲直接出力
-- ▼直接出力
huton = setup_prop_object(10107002)
set_pos(huton,{3.385,0.05,1.41})
set_rot(huton,{0,270,0})
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111151)
	Actor001 = InitializeCharacter_3D("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力

	--★★フレン★★:ルーシャスくん、一時はどうなるかと思ったけど<br>なんとか一命をとりとめたみたい
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01C900_350002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★フレン★★:ほんとによかった…<br>きっと、もう少ししたら目を覚ますと思う
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01C900_350003")

-- ▼直接出力
lookWeight = {0.9, 0, 0.6, 0.35}
lookat_delay_weight(Actor003, lookWeight,0.5)
keep_ik_lookat(Actor003, Actor001, "J_Head")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フレン★★:そのときは、また会いに来てね
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01C900_350004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★フレン★★:え？ディナタンを見なかったかって？<br>ううん。私は見てないよ
	Talk(Actor003,"CHRNAME_FREN","speech","L","MA_01C900_350005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ローラ★★:ルーシャス様が無事で、本当によかった<br>お姉ちゃんも嬉しそうだし…
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01C900_350007")

-- ▼直接出力
set_common_look_at(Actor002,Actor005)
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-64,1)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★ローラ★★:ノワールは学園の復興を手伝ってるんですよね？<br>今度、私たちも手伝いに行きます
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01C900_350008")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ローラ★★:あなたは私たちを助けてくれた<br>だから…今度は私たちが返す番です
	Talk(Actor002,"CHRNAME_LOLA","speech","L","MA_01C900_350009")

-- ▼直接出力
set_common_look_at(Actor001,Actor005)
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor005,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ラシア★★:ルーシャス様の容態も落ち着いて<br>ヴェルナルス様も安心したみたいです
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01C900_350011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ラシア★★:ノワールも…大変だったと思うけど<br>でも、あなたが無事でよかった
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01C900_350012")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ラシア★★:生きてればきっと、何度だってやり直せます<br>前を向いていきましょう。ね
	Talk(Actor001,"CHRNAME_RASIA","speech","L","MA_01C900_350013")

-- ▼直接出力
 --setup_small_camera_end()
setup_small_camera_start(RndCamera006)
set_common_look_at(Actor004,Actor005)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor005,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to Std_Loop")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ヴェルナルス★★:…ノワール<br>ルーシャス様を死なせないでくれて、感謝する
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01C900_350015")

	change_face(Actor004,"Normal")

	--★★ヴェルナルス★★:ルーシャス様はこれからのローマを導く存在<br>ここで終わる方ではないのだ
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01C900_350016")

-- ▼直接出力
 --[[
setup_small_camera_start()
set_common_look_at(Actor004,Actor005)
PlayActionDirect(Actor004,"to Wlk")
turn_lookat(Actor004,Actor005,0.5)
wait_time(0.5)
PlayActionDirect(Actor004,"to  Std_Talk")
 --]]
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★ヴェルナルス★★:お前は学園の立て直しに尽力しているそうだな<br>…復興した暁にはまた教鞭をとってもいい
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01C900_350017")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ヴェルナルス★★:ルーシャス様がお許しになればな
	Talk(Actor004,"CHRNAME_VERNARTH","speech","L","MA_01C900_350018")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10107002)
	InitializeLoad_Preload()
	load_area_scene_preload(111151)
	InitializeCharacter_3D_Preload("101037","001","101037001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101038","001","101038001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111151_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
