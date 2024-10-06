-- このluaスクリプトは、MA_01C110_14.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114101_01","114101_01_h")
Include("content_adv_advsmall_114101_01","Template114101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114101_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114101_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114101_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114101_01,CameraPos114101_01_008)
	InitializeTemplateRandomCamera114101_01()
	InitializeTemplate114101_01()
-- ▼直接出力
load_image("MA01C1101401", "content_still_10104002_image", "101040020_StillImage")
show_image("MA01C1101401", 0.0, 0.0, STILL_SWITCH_TIME,true,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
set_pos(Actor006, {2.992, 0, 9.263}) 
Hide(Actor007)
set_pos(Actor007, {3.211, 0, 7.585}) 
-- ▲直接出力
-- ▼直接出力
disp_calendar(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114101)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","002","101017002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101033","002","101033002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Joy")

	--★★ディナタン★★:マァル…！来てくれたんだね
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","MA_01C110_140001")


	--★★マルディサント★★:リンクできてりゃキラーズとマスターとは<br>お互いの場所を認識できるはずなのに
	Talk(Actor003,"CHRNAME_MALADISANT2","simple","N","MA_01C110_140002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:あのとき姿を消してから<br>ディーナの存在を感じられなくなってさ
	Talk(Actor003,"CHRNAME_MALADISANT2","simple","N","MA_01C110_140003")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor004,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor005,Actor003,"J_Head")
-- ▲直接出力

	--★★マルディサント★★:正直…心配したぜ
	Talk(Actor003,"CHRNAME_MALADISANT2","simple","N","MA_01C110_140004")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:でも、アタシが生きてるってことは<br>ディーナも無事なんだって信じてた
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140005")


	--★★マルディサント★★:で、数日前さ
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140006")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★マルディサント★★:バルバロイの気配とかすかに残った繋がり…<br>気配を感じた、ディーナの
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_140008","MA_01C110_140009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:学園はどうなってる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_140011")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マルディサント★★:ひどい有様だ<br>アーサーはもういない
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140012")

	change_face(Actor001,"Sad")

	--★★ノワール★★:…やっぱりアーサーが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_140013")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Sad")

	--★★ガレス★★:…アーサーだけじゃない
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_140014")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.0)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ガウェイン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_140015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:来てくれてありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_140017")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マルディサント★★:オニーサンを助けに来たんじゃねえ<br>アタシはディーナを迎えに来たんだ
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140018")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Sad")

	--★★ガレス★★:学園はひどい有様だよ<br>アーサーのせいで…
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_140019")

	goto Block1end

::Block1end::
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★リオネス★★:学園は今ランスロットとギネヴィアが<br>頑張ってなんとか再建してるんだ！
	Talk(Actor005,"CHRNAME_LYONESS2","speech","L","MA_01C110_140021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサーは…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_140022")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Normal")

	--★★マルディサント★★:行方知れずだ
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:ねえ、ここはどこなの…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_140024")

	change_face(Actor004,"Normal")

	--★★ガレス★★:どこって…<br>わからないままで、ずっとここにいたのか？
	Talk(Actor004,"CHRNAME_GARETH","speech","L","MA_01C110_140025")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:うん…<br>…私たち、なにもわからなくて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_140026")


	--★★ディナタン★★:ずっと夢を見ていたみたい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_140027")

	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Normal")

	--★★リオネス★★:でも確かにここは不思議な場所だな<br>なんか…雰囲気が違うっていうか
	Talk(Actor005,"CHRNAME_LYONESS2","speech","L","MA_01C110_140028")


	--★★リオネス★★:あたしたちもマルディサントがいなきゃ<br>見つけられなかった
	Talk(Actor005,"CHRNAME_LYONESS2","speech","L","MA_01C110_140029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_140030")


	--★★マルディサント★★:ここは妖精の森って言われる場所らしい<br>もしかしたら、それで…
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140031")

	PlayAction(Actor003,"to  Std_Talk")

	--★★マルディサント★★:いや、説明はあとだ<br>とにかく、森を抜けて学園に戻るぞ
	Talk(Actor003,"CHRNAME_MALADISANT2","speech","L","MA_01C110_140032")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
Appear(Actor006)
Appear(Actor007)
turn_lookat(Actor003,Actor007,0)
turn_lookat(Actor004,Actor007,0)
turn_lookat(Actor005,Actor006,0)
keep_ik_lookat(Actor001,Actor006,"J_Head")
keep_ik_lookat(Actor004,Actor006,"J_Head")
keep_ik_lookat(Actor002,Actor006,"J_Head")
keep_ik_lookat(Actor005,Actor006,"J_Head")
set_enable_auto_lookat_all(false)
fadein(FADE_TIME)
wait_time(FADE_TIME)

-- ▲直接出力
	PlayAction(Actor005,"to  Std_Joy")
-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★リオネス★★:その前にこいつらを片付けないとな！
	Talk(Actor005,"CHRNAME_LYONESS2","speech","L","MA_01C110_140034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("MA01C1101401", "content_still_10104002_image", "101040020_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114101)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","002","101017002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101033","002","101033002","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
