-- このluaスクリプトは、MA_01C112_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
Include("content_adv_advsmall_112021_03","112021_03_h")
Include("content_adv_advsmall_112021_03","Template112021_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera003 = SetTemplate("Actor004",nil,CharaPos112021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_008)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
 load_image("10301008", "content_still_10301008_image", "103010080_StillImage")
Hide(Actor004)
turn_lookat(Actor001,Actor002, 0)
turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_03_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_006)
	Camera003 = SetTemplate("Actor004",nil,CharaPos112021_03_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName112021_03,CameraPos112021_03_001)
	InitializeTemplateRandomCamera112021_03()
	InitializeTemplate112021_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(116030)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	Actor004 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ディナタン★★:えっと…頼まれた食材はこれで全部かな～<br>ほかは適当にって言われてたけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340002")

	PlayAction(Actor002,"to  Std_Worry")

	--★★ディナタン★★:ねえ、兄さん<br>あとなに買えばいいと思う？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340003")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:そうだな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340004")

	open_select_window_tag(Actor001,"Normal","MA_01C112_340005","MA_01C112_340006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Laugh")

	--★★ノワール★★:せっかくマーケットに来たんだし、<br>ホットドックでも食っていかないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340008")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ディナタン★★:買い食いは校則違反ですよ～？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340009")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:それに、ガレスさんのクリスマスメニュー<br>いっぱい試食するんだから、お腹空けとこうよ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:それもそうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ガレスへのプレゼントでも<br>買っていくか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340013")

	change_face(Actor002,"Smile")

	--★★ディナタン★★:それいいかも！<br>うーん…でも、なにが欲しいんだろう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340014")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:プレゼントを選ぶのって案外難しいね<br>やっぱり、ガウェインさんに聞いたほうが…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340015")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:あ…ごめん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340016")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	open_cutin(1,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:あ…
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C112_340018")

	close_cutin()
-- ▼直接出力
turn_lookat(Actor002,Actor001, 0.44)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:兄さん？どうしたの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340020")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
template2()
Appear(Actor004)
setup_small_camera_start()

lookat_weight(Actor002, 0.8, 0.3, 0.6, 0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")

--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:この店、ギネヴィアと来たんだ<br>宝石を見に
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:五月女王に選ばれなくて<br>ヤケ買いだって言って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340022")

	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どの宝石が一番いいかって<br>俺に聞いてきて、それで…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340023")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301008", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ギネヴィア★★:………それ、リッチな、かんじ…？
	Talk(Actor003,"CHRNAME_GUINEVERE","simple","N","MA_01C112_340025")


	--★★ノワール★★:…似合いそうだと思ったから
	Talk(Actor001,"CHRNAME_NOIR","simple","N","MA_01C112_340026")


	--★★ギネヴィア★★:じゃあ、それ！！
	Talk(Actor003,"CHRNAME_GUINEVERE","simple","N","MA_01C112_340027")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)

hide_image()
 
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)

 wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ディナタン★★:辛いこと、苦しいこと、いっぱい話してほしい<br>そしたら、少しは楽になるでしょ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340029")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:私でよければなんでも聞くから<br>兄妹に隠しごとはナシなんだからね？<br>
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor001,"to Wlk")
turn_lookat(Actor001,Actor002, 0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ごめん。ありがとう、ディナタン
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_340032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor001, 0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:えへへ…なんか寒くなってきたね<br>ガレスも待ってるし、そろそろ学園に戻ろうか<br>
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C112_340034")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
 load_image_preload("10301008", "content_still_10301008_image", "103010080_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(116030)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest(CameraAssetBundleName112021_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
