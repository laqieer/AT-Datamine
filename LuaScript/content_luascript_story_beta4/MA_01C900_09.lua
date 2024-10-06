-- このluaスクリプトは、MA_01C900_09.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_017,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_017)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_015,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_015)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_010,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_010)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110051_02_012,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_012)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
load_image("102040030_StillImage", "content_still_10204003_image", "102040030_StillImage")
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor005)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor006)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
DontChangeRandomCamera(true)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01C900_091001")


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01C900_091002")


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01C900_091003")


	--★★テロップ★★:…魔女から知らせがあった<br>「アーサーはカムランの丘で待つ」と
	Talk(Actor008,"telop","narration","N","MA_01C900_091004")


	--★★テロップ★★:
	Talk(Actor008,"telop","narration","N","MA_01C900_091005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6)
wait_time(1.2)
show_image("102040030_StillImage", 0.0, 0.0, 0.0, true, false)
fadein(0.6)
wait_time(0.6)
-- ▲直接出力

	--★★ケイ★★:…魔女から知らせがあった<br>「アーサーはカムランの丘で待つ」と
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090002")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME) --0.6秒
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER ) --0.6秒 + 0.8秒
DontChangeRandomCamera(false)
-- ▲直接出力
	change_face(Actor006,"Anger")

	--★★ケイ★★:そこですべての決着をつけようと
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090003")


	--★★ルーシャス★★:とうとう、王自らのお出ましか
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01C900_090004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★ガレス★★:それと、多分兄さんもいる
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01C900_090005")

	change_face(Actor006,"Normal")

	--★★ケイ★★:さらに吉報なのか凶報なのかはわからぬが…
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090006")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:報せがひとつ<br>調査部隊から入った
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090007")


	--★★ノワール★★:いったいなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_090008")


	--★★ケイ★★:ブリテン全土にいたバルバロイが<br>一定方向に向かい始めている
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090009")

	change_face(Actor007,"Surprise")

	--★★ルーシャス★★:一定方向とは？
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01C900_090010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ケイ★★:おそらくカムランの丘に向かっていると
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090011")

	change_face(Actor003,"Surprise")

	--★★マーリン★★:すべての力がカムランの丘に集まっていると…？
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_090012")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:そのようだ
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:とにかくカムランの丘に来いってことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_090014")


	--★★モルドレッド★★:カチ込む準備できてんだろうな？
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C900_090015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C900_090016","MA_01C900_090017")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:ああ。もう…戦うしかない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_090019")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Anger")

	--★★ケイ★★:…そうだな<br>もはや、それしか道は残されていない
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090020")

	change_face(Actor006,"Sad")

	--★★ケイ★★:…なぜ私には、戦う力がないんだ<br>今ほど悔しいと思ったことはない
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090021")

	change_face(Actor006,"Sad")

	--★★ケイ★★:義弟が道を誤ったのであれば<br>義兄がそれを正してやらねばならないのに
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01C900_090022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:なんとか説得できないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_090024")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:兄さん？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_090025")

	change_face(Actor004,"Surprise")

	--★★モルドレッド★★:あ？今更なに言ってやがる
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C900_090026")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★マーリン★★:ノワール様<br>私へのお気遣いであれば、不要です
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_090027")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Anger")

	--★★マーリン★★:私たちがアーサーを止めなければ<br>…それがアーサーにとって最善のことだから
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_090028")

	goto Block1end

::Block1end::
	PlayAction(Actor007,"to  Std_Worry")

	--★★ルーシャス★★:しかし、継承者のキラーズはよいのか<br>気持ちの整理がついていないのでは？
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01C900_090030")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:私は…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_090031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ディナタン★★:私は…戦うだけです<br>兄さんの武器として
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C900_090032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★マーリン★★:ディナタン…
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01C900_090033")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★ルーシャス★★:そうか<br>ならば余はもうなにも言うまい
	Talk(Actor007,"CHRNAME_LUCIUS","speech","L","MA_01C900_090034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Serious")

	--★★ノワール★★:行こう…アーサーのもとへ<br>――カムランの丘へ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C900_090035")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102040030_StillImage", "content_still_10204003_image", "102040030_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
