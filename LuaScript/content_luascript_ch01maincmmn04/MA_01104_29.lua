-- このluaスクリプトは、MA_01104_29.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_001)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
load_image("10301004", "content_still_10301004_image", "103010040_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115030)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ティルフィング★★:大変おめでとうございます<br>そしてよろしくお願いします、ノワール卿
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290002")


	--★★ノワール★★:…キミは結局、その－－誰なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ティルフィング★★:お話出来ません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:どうして…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:この歴史の流れを濁らせてしまう<br>私に伝えられることはわずか
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290007")


	--★★ティルフィング★★:アナタの『本当の武器』は他にある<br>私はそれを見つけるキッカケとなります
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290008")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Sad")

	--★★ノワール★★:わ、訳がわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_290010","MA_01104_290011","MA_01104_290012")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:教えてくれる日はくるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290014")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…私の口からすべてを述べる日は<br>恐らく、来ないでしょう
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290015")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:なによソレ、意味深に
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290016")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:そのような時間はありません<br>ただ、ノワール卿が真実を耳にする道は…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290017")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:それを選び取ることは、できるかもしれません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:儀式もなしにバルバロイを倒せる<br>GSもなしにキラーズを得られる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の能力っていったい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…いずれわかるときがくるはずです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290024")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:理解せざるをえない日が<br>きます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290025")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:キャメリアードに刺さっていたのはなぜだ？<br>それも答えられないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290027")

	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:ノワール、いいよ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290028")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:剣抜いたら人が出てきたなんて<br>わけわかんないことが起きてさ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290029")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:なんでそんなことになってるのかなんて<br>…説明されても、きっとわかんない
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290030")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:…申し訳ありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290031")

	goto Block1end

::Block1end::
	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:なんも言ってくれないもんね<br>本当のコトを、誰も
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290033")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290034")

	change_face(Actor004,"Sad")

	--★★ギネマウア★★:………殿下
	Talk(Actor004,"NPCNAME_0070","speech","L","MA_01104_290035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:…ごめん、なさい
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290036")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:あ、あの、ティルフィング、ごめんなさい<br>本当に、ちょっと…疲れてるのかも
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290037")


	--★★ティルフィング★★:…いえ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01104_290038")


	--★★ギネヴィア★★:あの…明日からはいつも通りに戻るから<br>………ばいばい
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_290039")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ギネマウア★★:…あの、ノワール様
	Talk(Actor004,"NPCNAME_0070","speech","L","MA_01104_290041")

-- ▼直接出力
keep_ik_lookat(Actor001, Actor004, "J_Head")
lookat_delay_weight(Actor001, {1.0, 0, 0.5, 0.2} , 0.5)
-- ▲直接出力

	--★★ギネマウア★★:殿下のワガママに<br>辟易しませんか…？
	Talk(Actor004,"NPCNAME_0070","speech","L","MA_01104_290042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_290043","MA_01104_290044")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…正直に言えば、少し…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290046")

	change_face(Actor004,"Sad")

	--★★ギネマウア★★:そうですよね…
	Talk(Actor004,"NPCNAME_0070","speech","L","MA_01104_290047")

	change_face(Actor004,"Normal")

	--★★ギネマウア★★:いつもお付き合いいただき<br>ありがとうございます…
	Talk(Actor004,"NPCNAME_0070","speech","L","MA_01104_290048")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:いえ！<br>気にかけてもらってむしろありがたいです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290050")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:教室にいても、針のムシロだったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290051")

	change_face(Actor004,"Normal")

	--★★ギネマウア★★:…そう言っていただけると<br>殿下も幾分か救われます
	Talk(Actor004,"NPCNAME_0070","speech","L","MA_01104_290052")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ギネマウア★★:それでは本日はこのあたりで<br>…ごきげんよう
	Talk(Actor004,"NPCNAME_0070","speech","L","MA_01104_290054")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor004)
lookat_delay_weight_reset(Actor001 , 1)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290056")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301004", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ギネヴィア★★:…大丈夫よ<br>まだ覚えてるもの
	Talk(Actor003,"CHRNAME_GUINEVERE","simple","N","MA_01104_290058")

	change_face(Actor003,"Sad")

	--★★ギネヴィア★★:…………パパ
	Talk(Actor003,"CHRNAME_GUINEVERE","simple","N","MA_01104_290059")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 --カメラ
DontChangeRandomCamera(true)
on_camera(Camera001)
--エフェクト終了
hide_image() 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…父さん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_290061")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10301004", "content_still_10301004_image", "103010040_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115030)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
