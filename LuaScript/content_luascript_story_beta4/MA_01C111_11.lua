-- このluaスクリプトは、MA_01C111_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-170,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	Camera003 = SetTemplate("Actor003",-125,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera004 = SetTemplate("Actor004",-15,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
set_pos(Actor003,{8.9,0,-0.2})
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor004,"J_Head")
keep_ik_lookat(Actor002,Actor004,"J_Head")
keep_ik_lookat(Actor003,Actor004,"J_Head")
keep_ik_lookat(Actor004,Actor001,"J_Head")
lookat_weight(Actor001,0.7,0.03,0.7,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ケイ","挨拶")
-- ▲直接出力

	--★★ケイ★★:ハロウィンの準備で忙しいところ悪いが<br>頼まれごとをしてくれないか
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ケイ★★:街道にもバルバロイが現れ<br>多くの人々を襲っている
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110003")


	--★★ケイ★★:報告されている魔女の力の<br>増大も関係しているのかもしれない
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110004")


	--★★ケイ★★:円卓の騎士として…<br>我々はログレスの民を守らねばならない
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C111_110006","MA_01C111_110007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
lookat_delay_weight(Actor001, 0.8,0.08,0.6,0,0.5)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかった。行こう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_110009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ディナタン★★:うん<br>放っておくわけにはいかないもんね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_110010")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
lookat_delay_weight(Actor001, 00.7,0.03,0.7,0,0.7)
keep_delay_ik_lookat(Actor001,Actor004,"J_Head",1.0)
 --PlayPartVoice("ケイ","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:話が早くて助かる
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110012")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:円卓の騎士か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_110014")

-- ▼直接出力
 --PlayPartVoice("ケイ","悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:なにか？
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや…そもそも、円卓は<br>アーサーが用意した場なんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_110016")

-- ▼直接出力
 --PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それなのに、アーサーがいないってのが<br>どうしても慣れなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_110017")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ","肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:…貴公の言いたいことはわかる
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:だが、たとえ王が不在でも<br>円卓の騎士が負うべき役割は変わらない
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110019")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_110020")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ケイ","落胆")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ケイ★★:すまないな<br>本来ならばもっと人員を割きたいところだが…
	Talk(Actor004,"CHRNAME_KAY","speech","L","MA_01C111_110022")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat_all(false)
 --PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気にするなって<br>他にもやることがたくさんあるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C111_110023")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガレス","肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガレス★★:そうそう。それに今回は<br>ガレスちゃんが手伝ってあげるから安心して
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_110024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Joy")
turn_chara(Actor003,-80,0.3)
 --PlayPartVoice("ガレス","喜び")
-- ▲直接出力

	--★★ガレス★★:お弁当、たくさん作ってってあげるからね！
	Talk(Actor003,"CHRNAME_GARETH","speech","L","MA_01C111_110025")

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
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
