-- このluaスクリプトは、MS_002_022.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_100011_04","100011_04_h")
Include("content_adv_advsmall_100011_04","Template100011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos100011_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_523_01_DBoff_ms0002_01_Controller","to Std_Loop",CameraAssetBundleName100011_04,CameraPos100011_04_002)
	Camera002 = SetPlayerTemplate("Actor002",nil,CharaPos100011_04_020,CameraAssetBundleName100011_04,CameraPos100011_04_020)
	Camera003 = SetTemplate("Actor003",nil,CharaPos100011_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_524_01_StdController","to Std_Loop",CameraAssetBundleName100011_04,CameraPos100011_04_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos100011_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_511_01_StdController","to Std_Loop",CameraAssetBundleName100011_04,CameraPos100011_04_004)
	InitializeTemplateRandomCamera100011_04()
	InitializeTemplate100011_04()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
CUT10 =  cat_template_camera("P10_Cam")
CUT11 =  cat_template_camera("P11_Cam")
CUT13 =  cat_template_camera("P13_Cam")
CUT14 =  cat_template_camera("P14_Cam")
CUT15 =  cat_template_camera("P15_Cam")
CUT16 =  cat_template_camera("P16_Cam")
CUT17 =  cat_template_camera("P17_Cam")
CUT18 =  cat_template_camera("P18_Cam")
CUT19 =  cat_template_camera("P19_Cam")
CUT20 =  cat_template_camera("P20_Cam", Actor002)
-- ▲直接出力
-- ▼直接出力
chair01 = get_object("geo_chair_13")
set_pos(chair01,{4.748 , 0 , 0.516 })

chair02 = get_object("geo_chair_14")
set_pos(chair02,{1.817 , 0 ,0.516})

chair03 = get_object("geo_chair_20")
set_pos(chair03,{-2.73 , 0 , 0.516})
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(CUT10)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(100011)
	Actor001 = InitializeCharacter_3D("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializePlayerCharacter("Actor002")
	Actor003 = InitializeCharacter_3D("101002","002","101002002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101035","003","101035003","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
wait_time(0.5)
PlayPartVoiceDirect("フライクーゲル","0062")
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
setup_small_camera_start(CUT11)
wait_time(1)
PlayActionDirect(Actor001,"to MS002_022_Sit01Sob_Loop")
wait_time(2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01Sob_End")
wait_time(2)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101070001_sp_0001_3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:…──ダーリン
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220004")


	--★★フライクーゲル★★:ひさしぶり
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220005")

	open_select_window_tag(Actor002,"Normal","MS_002_0220007","MS_002_0220008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT13)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0021")
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:…うん
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220011")

	change_face(Actor001,"Special")

	--★★フライクーゲル★★:ありがとう<br>わたしに気を使ってくれて
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220012")

	change_face(Actor001,"Special")

	--★★フライクーゲル★★:やさしいね。ダーリン
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_start(CUT13)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0031")
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:………あ、う
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220017")

-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01LookDown_Start")
wait_time(0.4)
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:うん。うん…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220018")

-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01LookDown_End")
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:そうだよね。ダーリン
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220019")

	goto Block1end

::Block1end::
-- ▼直接出力
CloseTalkWindow()
wait_time(1)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0067")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:…そっか
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220021")


	--★★フライクーゲル★★:ダーリンはさっきの戦いで<br><ruby=ノワール>過去の継承者</ruby>の記憶を取り戻した、ケド…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220022")


	--★★フライクーゲル★★:過去に潜る前の記憶は<br>まるごと欠損したままで──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220024")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0060")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★レーヴァテイン★★:…それはもう、消えて…戻らない
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220025")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力

	--★★フライクーゲル★★:………そっ、かぁ──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220026")

-- ▼直接出力
setup_small_camera_start(CUT14)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101002001_sp_0002_1")
-- ▲直接出力

	--★★レーヴァテイン★★:フライクーゲル…<br>あなたと友達だったことも
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220027")


	--★★フライクーゲル★★:………全部リセット
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220028")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0060")
-- ▲直接出力

	--★★レーヴァテイン★★:………不自由だね<br>いろいろ
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220029")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:うん。だいじょぶっ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220030")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0058")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★レーヴァテイン★★:大丈夫なわけ、ないでしょ………？
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220031")

-- ▼直接出力
setup_small_camera_start(CUT15)
PlayActionDirect(Actor001,"to MS002_022_Sit01Panic")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0031")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:あっ、あっ、ちがうんだよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220032")


	--★★フライクーゲル★★:ダーリンの記憶がなくなってもイイとかじゃなく<br>わたしのキモチ的に大丈夫っていうか…！
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220034")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0066")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:う？ううん、えと、ショックだよ…っ！大丈夫っていうのは、そういう大丈夫じゃ…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220035")

-- ▼直接出力
setup_small_camera_start(CUT13)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0007")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ロンギヌス★★:わ、わかります、わかりますから…
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","MS_002_0220036")


	--★★フライクーゲル★★:なんとかかんとか、グッとこらえられる<br>わたし側の問題っていうか──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220037")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:ああっ、こらえられる程度のダメージ<br>とかいうことでもないんだけどね…！？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220038")

-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01LookDown_Start")
PlayPartVoiceDirect("フライクーゲル","0062")
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:あっ、ウッ、あぁっ、ち、違う──<br>わたしのことばっか言いたかったワケじゃなくて
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220039")

-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0037")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★レーヴァテイン★★:………ごめん
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220040")

-- ▼直接出力
PlayActionDirect(Actor003,"to  Std_Sad02")
SkipDefaultMotion(Actor003)
-- ▲直接出力

	--★★レーヴァテイン★★:私が迎えに行ったから…
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220041")

-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01LookDown_End")
PlayPartVoiceDirect("フライクーゲル","0023")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:れ、レーヴァのせいじゃないよ<br>ダーリンの…アレコレは
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220042")

-- ▼直接出力
setup_small_camera_start(CUT15)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01LookDown_Start")
PlayPartVoiceDirect("フライクーゲル","0021")
-- ▲直接出力
	change_face(Actor001,"Special")

	--★★フライクーゲル★★:本当はぜんぶわたしが<br>やらなきゃいけないことだったんだし
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220043")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("フライクーゲル","0058")
-- ▲直接出力

	--★★フライクーゲル★★:逆に、レーヴァにやらせちゃってごめん…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220044")

	PlayAction(Actor003,"to Std_Loop")

	--★★レーヴァテイン★★:……
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220045")

	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:いちばんつらいのはダーリンで<br>レーヴァだって大変で──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220046")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
voice_play("VO_101002001_sp_0002_3")
-- ▲直接出力

	--★★レーヴァテイン★★:…私のことは、いい
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220047")

-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01LookDown_End")
PlayPartVoiceDirect("フライクーゲル","0056")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:もっ、もちろんね？
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220049")

-- ▼直接出力
setup_small_camera_start(CUT16)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:人間、つらさに順序なんてなくて、本来たぶん！<br>ただ起きた出来事への向き合いかたの問題で…
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220050")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("リリアーナ","0039")
-- ▲直接出力

	--★★ロンギヌス★★:わ、わかります、言わんとしていることは…っ
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","MS_002_0220051")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0057")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:………さよならなワケじゃないしさ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220052")

	change_face(Actor004,"Sad")

	--★★ロンギヌス★★:…そう、ですね
	Talk(Actor004,"CHRNAME_LONGINUS","speech","L","MS_002_0220053")

-- ▼直接出力
setup_small_camera_start(CUT13)
change_face(Actor004,"Normal")
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MS_002_0220056")
	if is_select(1) then
		goto Block2_1
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor001,"to MS002_022_Sit01_End")
-- ▲直接出力
	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★フライクーゲル★★:それこそ、ダーリンのせいじゃないよ！
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220061")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(CUT17)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
voice_play("VO_101070001_sp_0001_1")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★フライクーゲル★★:ダーリン<br>…わたしはね
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220062")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0013")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★フライクーゲル★★:またきみに会えて、うれしい
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220063")

	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:きみの思い出がなくなって、これから<br>はじめましての不自由がどれだけ襲って来ても
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220064")

-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0038")
-- ▲直接出力

	--★★フライクーゲル★★:わたしが全部<br>撃ち抜いてみせる
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220065")


	--★★フライクーゲル★★:そのためならわたし、なんでもするよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220066")

-- ▼直接出力
setup_small_camera_start(CUT18)
set_animationcontroller(Actor001, "Chr_523_01_StdController", "to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0002")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★レーヴァテイン★★:…随分遠回しな言いかたするね<br>フライクーゲル…？
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("フライクーゲル","0058")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★フライクーゲル★★:うん。だからごめんね、レーヴァ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220068")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("レーヴァテイン","0029")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★レーヴァテイン★★:なにが？
	Talk(Actor003,"CHRNAME_LAEVATEIN","speech","L","MS_002_0220069")

-- ▼直接出力
setup_small_camera_start(CUT19)
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★フライクーゲル★★:今度こそ<br>わたしが絶対に──
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220070")

-- ▼直接出力
setup_small_camera_start(CUT20)
-- ▲直接出力

	--★★フライクーゲル★★:──絶対にきみを、自由にするよ
	Talk(Actor001,"CHRNAME_FREIKUGEL","speech","L","MS_002_0220071")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(100011)
	InitializeCharacter_3D_Preload("101070","001","101070001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101002","002","101002002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101035","003","101035003","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName100011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
