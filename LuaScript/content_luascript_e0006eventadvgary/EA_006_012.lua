-- このluaスクリプトは、EA_006_012.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_02","110122_02_h")
Include("content_adv_advsmall_110122_02","Template110122_02_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_522_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_02,CameraPos110122_02_004)
	InitializeTemplateRandomCamera110122_02()
	InitializeTemplate110122_02()
-- ▼直接出力
Hide(Actor002)

-- ▲直接出力
-- ▼直接出力
hideobj01 = get_object("geo_uv03_obj01_foodA")
set_pos(hideobj01, {0,-20, 0})
-- ▲直接出力
-- ▼直接出力
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101032","001","101032001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_2DOnly("101009","002","101009002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ガレス★★:………
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
character_in_move_walk_offset(Actor002,CharaPos004,-2.5,0,-0.25,2.0)
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
voice_play("VO_101009_sp_0020_1")
-- ▲直接出力

	--★★ノワール★★:ガレス
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120005")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★ノワール★★:いや、そういうわけじゃ…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120007")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ガレス★★:なにか出してやりたいところだけど<br>今は無理かな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120008")


	--★★ガレス★★:…実は今、食材を切らしちゃったんだ<br>ちょっと料理に失敗しちゃって
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★ノワール★★:めずらしいな<br>ガレスが失敗だなんて
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120010")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0014")
-- ▲直接出力

	--★★ガレス★★:あはは…<br>考えごとしてたからかな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120011")

-- ▼直接出力
voice_play("VO_101009_sp_0020_3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:ガレス…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120012")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ガレス★★:…やっぱ、気になっちゃってさ
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120013")

-- ▼直接出力
voice_play("VO_101032_sp_0005_3")
-- ▲直接出力

	--★★ガレス★★:兄さん、ろくなご飯を<br>食べられてないんじゃないかって
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:ガレスって、よく<br>ガウェインの飯のことを心配するよな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ガレス","0038")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:そうかも。母さんの影響かな<br>昔、同じことをよく言ってたから
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120016")


	--★★ノワール★★:お母さんが…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120017")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ガレス★★:兄さんは生まれてすぐに家を出されたから<br>気になってしょうがなかったんだろうな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120018")


	--★★ガレス★★:時々思い出したように兄さんのことを心配して<br>それでわたしも一緒になって心配してた
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120019")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:まだ会ったこともない頃からずっと
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:それで、癖になってるのかも
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力

	--★★ノワール★★:そうだったのか…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120023")

	change_face(Actor001,"Normal")

	--★★ガレス★★:この学園に来て<br>兄さんと同じ食卓を囲めるようになって
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120024")

	change_face(Actor001,"Sad")

	--★★ガレス★★:もう心配する必要はなくなった<br>…と思ったんだけどな～
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101009_sp_0020_3")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:ガレス…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120027")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Laugh")

	--★★ガレス★★:…なーんて<br>泣きゴトを言ってる場合じゃないよな
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120028")

	open_cutin(1,2)
	on_cutin(1,Actor001,"Smile")

	--★★ガレス★★:今そこにある食卓を守るのが<br>円卓の騎士六ノ座ガレスちゃんの務め！
	Talk(Actor001,"CHRNAME_GARETH","speech","N","EA_006_0120029")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0011")
-- ▲直接出力
	on_cutin(1,Actor001,"Smile")

	--★★ガレス★★:シャキッとしなきゃ、シャキッと！
	Talk(Actor001,"CHRNAME_GARETH","speech","N","EA_006_0120030")

	close_cutin()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:強いな…さすがは円卓の騎士の先輩
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120031")

	change_face(Actor002,"Normal")

	--★★ノワール★★:
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ガレス★★:この間の３月だぞ。実は円卓歴は<br>ノワールとそこまで変わらないんだ～♪
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120033")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0046")
-- ▲直接出力

	--★★ノワール★★:そうだったのか<br>やっぱり最初から皆に認められて？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","EA_006_0120034")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ガレス★★:まさか！ノワールと一緒で<br>最初はなかなか認めてもらえなかった
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120035")

-- ▼直接出力
PlayPartVoiceDirect("ガレス","0010")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ガレス★★:
	Talk(Actor001,"CHRNAME_GARETH","speech","L","EA_006_0120036")

-- ▼直接出力
CloseTalkWindow()
bgm_play("Stop_BGM_Bus_LongFade")
show_image("101010150", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★テロップ★★:３月某日
	Talk(Actor003,"","simple","L","EA_006_0120040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101032","001","101032001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
