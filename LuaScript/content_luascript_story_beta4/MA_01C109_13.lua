-- このluaスクリプトは、MA_01C109_13.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_007)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
load_image("10304001", "content_still_10304001_image", "103040010_StillImage")
 --load_image("10301006", "content_still_10301006_image", "103010060_StillImage")
 --load_image("103030010", "content_still_10303001_image", "103030010_StillImage")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
set_pos(Actor003,CharaPos110011_04_107)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115014)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力

	--★★ディナタン★★:一緒に帰ろ。兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130003")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:珍しいな<br>いつもマルディサントと一緒なのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力

	--★★ディナタン★★:マァルにフラれちゃったみたい<br>「オニーサンのそばにいてやんな」…だって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130005")


	--★★ディナタン★★:不思議だね<br>ちょっと、なんだか
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C109_130007","MA_01C109_130008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130010")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ディナタン","悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:だって私は変わらないのに<br>立場は変わっちゃうんだなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130011")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうもんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130012")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:さっすが継承者様だね<br>兄さんは
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130013")

-- ▼直接出力
 --PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:からかうなよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺だって始めは戸惑った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:そうだね、知ってる
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そばにいてくれると安心するよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130018")

-- ▼直接出力
 --PlayPartVoice("ディナタン","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:本当？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130019")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera007)
wait_time(0.52)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:この学園に来る前と、今<br>いろいろ…たくさん変わっちゃったけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130020")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:まだ私<br>そばにいていい？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130021")

-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:変わったのは肩書きだけだ<br>それ以外は何も──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130022")

-- ▼直接出力
 --PlayPartVoice("ディナタン","悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:変わらない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130023")

-- ▼直接出力
wait_time(0.44)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:…変わってない？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130024")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか心配事か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130026")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ディナタン","落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:マァルが言ってたでしょ？<br>「いけないことをしちゃうのはダメか」って
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130027")


	--★★ディナタン★★:世界を救う継承者なら<br>最強騎士や王妃様だって選べた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:アーサー様も驚いてた
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130029")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:以前にイゾルデさんに言われたことを<br>思い出したの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130030")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
setup_small_camera_end()
DontChangeRandomCamera(true)
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10304001", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ディナタン★★:「己の至らなさを知れ」<br>「兄さんはいずれは平和を継ぐ鍵となる人」
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","MA_01C109_130032")


	--★★ディナタン★★:「私にはなにもできない」<br>「私が選ばれれば平和への足を引っ張る」
	Talk(Actor002,"CHRNAME_DINATAN","simple","N","MA_01C109_130033")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 --エフェクト終了
hide_image()
 --スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタン…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130034")

-- ▼直接出力
 --PlayPartVoice("ディナタン","悲しみ")
-- ▲直接出力

	--★★ディナタン★★:だから私たち──
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130035")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:いけないこと<br>してるのかなあって思ったの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C109_130037")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_LongFade")
se_play("SE_ADV_MA_01A112_31_Earthquake")
shake_camera(Camera002, 0.5, 5.2)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Surprise")
change_face(Actor001,"Surprise")
wait_time(1.0)
PlayActionDirect(Actor002,"to  Std_Surp")
DontChangeRandomCamera(true)
on_camera(RndCamera090)
shake_camera(RndCamera090, 0.5, 4.0)
-- ▲直接出力
-- ▼直接出力
wait_time(4.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:なんだ…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_130039")

-- ▼直接出力
CloseTalkWindow()
 --EntryWalk(Actor003,Camera003,EntryData110011_04_07,CameraAssetBundleName110011_04,CameraPos110011_04_107)
DontCameraOffset(Actor003)
IN_RUN(Actor003,CharaPos110011_04_007)
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("マルディサント","落胆")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★マルディサント★★:出番だぜ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01C109_130041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10304001", "content_still_10304001_image", "103040010_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115014)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
MobsNo = 0
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
