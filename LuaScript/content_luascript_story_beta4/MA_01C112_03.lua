-- このluaスクリプトは、MA_01C112_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_04","110111_04_h")
Include("content_adv_advsmall_110111_04","Template110111_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_003)
	Camera002 = SetTemplate("Actor002",-36.2,CharaPos110111_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_002)
	Camera003 = SetTemplate("Actor003",270,CharaPos110111_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_004)
	Camera005 = SetTemplate("Actor005",250,CharaPos110111_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_04,CameraPos110111_04_005)
	InitializeTemplateRandomCamera110111_04()
	InitializeTemplate110111_04()
-- ▼直接出力
Hide(Actor001)
Hide(Actor004)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_AfterDinatan_General1_Start")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール3★★:あれは…
	Talk(Actor005,"CHRNAME_NOIR","speech","L","MA_01C112_030002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor002,Actor005,0.5)
wait_time(0.5)
PlayActionDirect(Actor002,"to Std_Loop")
 --PlayPartVoice("市民中年_男1", "挨拶")
-- ▲直接出力

	--★★市民（中年男）★★:あぁ、ノワール！ちょっとこっちに来てくれ！
	Talk(Actor002,"NPCNAME_0019","speech","N","MA_01C112_030003")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED)
setup_small_camera_start(RndCamera003)
Hide(Actor005)
Appear(Actor004)
turn_lookat(Actor002,Actor004, 0)
turn_lookat(Actor004,Actor002, 0)
wait_time(FADE_TIME)
fadein(FADE_TIME)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ノワール2★★:おじさん、どうした？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C112_030005")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("市民中年_男1", "悲しみ")
-- ▲直接出力

	--★★市民（中年男）★★:どうしたもこうしたもないよ<br>なんとかしてくれ、アレ
	Talk(Actor002,"NPCNAME_0019","speech","N","MA_01C112_030006")


	--★★市民（中年男）★★:皇太子サマときたら<br>あそこでずっと棒立ちして店を睨んでるんだ
	Talk(Actor002,"NPCNAME_0019","speech","N","MA_01C112_030007")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("市民中年_男1", "落胆")
-- ▲直接出力

	--★★市民（中年男）★★:用があるなら言ってほしいんだがね<br>ったく、偉い人の考えることはわからないよ
	Talk(Actor002,"NPCNAME_0019","speech","N","MA_01C112_030008")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール2★★:わかった。俺が話してくるよ
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01C112_030009")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED)
Hide(Actor004)
Appear(Actor001)
turn_lookat(Actor003,Actor001, 0)
turn_chara(Actor002,-57.6,0)
setup_small_camera_start(RndCamera008)
wait_time(FADE_TIME)
fadein(FADE_TIME)
wait_time(1.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "驚き")
-- ▲直接出力

	--★★ルーシャス★★:継承者か<br>余になにか用でも？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030011")

	open_select_window_tag(Actor001,"Normal","MA_01C112_030012","MA_01C112_030013")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか買い物でもしたいのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030015")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:何故そう思う
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030016")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、だって…店をじっと見つめるって<br>それ以外なくないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030017")

	change_face(Actor003,"Normal")

	--★★ルーシャス★★:余は市場視察をしていただけだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:ふむ…やはりローマには劣るな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030020")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:あっそ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030021")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:おい、あんまりジロジロ見るなよ<br>店の人が困ってるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030023")

	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:いきなり来て言うことがそれか<br>まったく不躾にもほどがある
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030024")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:う…けど、買う気はないんだろ？<br>冷やかしはよくないっていうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030025")

	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:買う気が無いと誰が言ったのだ<br>余が気に入れば当然、その対価は支払うとも
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:まぁ、今日は金を持ち合わせていないが
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030027")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:やっぱり買う気ないじゃないか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030029")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:それにしても、ずいぶん活気のある街だ<br>あれだけのことがあったというのに
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ログレスの民は強いんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030032")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ルーシャス★★:ほう、そなたはそう思うのか<br>継承者は、王とは物の見かたが違うようだな
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030033")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ルーシャス★★:余はここで行き交う民の声を聞いたぞ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030034")

-- ▼直接出力
wait_time(0.44)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ルーシャス★★:「アーサー様に裏切られた、信じていたのに」<br>「でも大丈夫。我々には円卓の騎士がいる」
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030035")


	--★★ルーシャス★★:「円卓の騎士がきっとなんとかしてくれる」
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030036")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ルーシャス★★:民とは変化を恐れる、弱きものだ<br>故に日常を取り戻そうと現状に適応を急ぐ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030038")


	--★★ルーシャス★★:王に棄てられた民は王に代わる心の拠り所を<br>同じく王に棄てられた円卓の騎士に求めている
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030039")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:つまりそなたの役割は<br>そなたが思う以上に重責というわけだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030040")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")

	--★★ルーシャス★★:本来、その弱き民を背負うのは<br>王たる者のさだめであるわけだが
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030041")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:そなたに、それを背負う覚悟があるか？
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","MA_01C112_030042")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_030043")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力

	--★★市民（男）★★:大変だ！バルバロイが！！
	Talk(Actor006,"NPCNAME_0156","speech","N","MA_01C112_030044")

-- ▼直接出力
bgm_play("BGM_Battle_AfterDinatan_General1_Start")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:！バルバロイか！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C112_030046")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	on_cutin(2,Actor003,"Normal")

	--★★ルーシャス★★:そなた以上に無粋な輩が出たようだな<br>ついてこい
	Talk(Actor003,"CHRNAME_LUCIUS","speech","N","MA_01C112_030047")

	close_cutin()
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Battle_AfterDinatan_General1_Start")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
