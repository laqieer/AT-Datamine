-- このluaスクリプトは、MA_01A110_31.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110141_01","110141_01_h")
Include("content_adv_advsmall_110141_01","Template110141_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110141_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_002)
	Camera002 = SetTemplate("Actor002",184,CharaPos110141_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110141_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110141_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110141_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_001)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110141_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_006)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110141_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_004)
	Camera008 = SetTemplate("Actor008",nil,CharaPos110141_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110141_01,CameraPos110141_01_007)
	InitializeTemplateRandomCamera110141_01()
	InitializeTemplate110141_01()
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110141)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	Actor009 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor007,"to  Std_Talk")
	change_face(Actor007,"Smile")

	--★★モルガン★★:平和の騎士ノワールくん、いらっしゃ?い♪
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310002")


	--★★アーサー★★:こんなところに呼び出したのは<br>ほかでもない
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310003")

	change_face(Actor004,"Smile")

	--★★アーサー★★:学園祭の話をしたら<br>義姉さんが張り切ってしまってな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★モルガン★★:みんなが元気になるためのお祭りでしょ<br>お姉さん踏ん張っちゃうんだから～！
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310005")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:出店に関してはマルイルに頼んでみたわ<br>祭の開催告知についてはキッスさんに話してある
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310006")

	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:期間はあんまりないけど<br>ふたりならうまくやってくれるはずよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310007")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:ありがとうございます…ギネヴィア様
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310008")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:わたしはモルガン先生のアイデアを<br>実行に移しただけだけどね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:限られた人脈・資源を有効に使うのが<br>モットーですから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Appl")
	change_face(Actor004,"Serious")

	--★★アーサー★★:そして懸案すべきはメインイベントだ！<br>盛り上がり如何ではみんなの士気に関わるのでな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310011")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:ちゃんと乗り気よね、王様
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310013")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★エレイン★★:ふふ、ですね
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)

	--★★モルガン★★:ね、どんなものになると思う？<br>実行委員のノワールくん
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_310017","MA_01A110_310018","MA_01A110_310019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな…<br>お芝居なんてどうだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310021")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:みんなに俺たちの想いを伝える手段としても<br>いいんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310022")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★アーサー★★:ふむ<br>さすがはノワールだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな…<br>音楽なんてどうだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310025")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★アーサー★★:音楽か…それもいいな<br>トリスタンにみっちり特訓してもらって…
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310026")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★ノワール★★:うっ！？<br>そ、それは大変そうだな…やめよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310027")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうだな…<br>武道大会なんてどうだろう？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310029")

	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Sad")

	--★★アーサー★★:俺も最初は<br>それを義姉さんに提案したんだがな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310030")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Normal")

	--★★モルガン★★:男の子も女の子も<br>一緒に参加できるものにしたいのよ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310031")

	goto Block1end

::Block1end::
	change_face(Actor007,"Normal")

	--★★モルガン★★:実はね私、考えたの<br>みんなの士気を上げるために『劇』をやろうって
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310033")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor006, {1.0, 0.08, 0.5, 0.3} , 1.0)
keep_ik_lookat(Actor006, Actor003, "J_Head")
-- ▲直接出力

	--★★マルディサント★★:グラストンベリー劇場<br>座付き作家のアタシがいるしな
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A110_310034")

-- ▼直接出力
lookat_delay_weight_reset(Actor006,0.8)
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ディナタン★★:ロンディニウムの孤児たちにも<br>希望を持ってもらえるようなものとしてね
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01A110_310035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マルディサント★★:金コートの騎士が悪辣な魔王から<br>攫われたお姫様を助け出す、勧善懲悪ものだ！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A110_310037")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★アーサー★★:わかりやすい題材でいいな！<br>幼い子供たちも楽しめる！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310039")

	change_face(Actor005,"Surprise")

	--★★エレイン★★:金コートの騎士は先輩、ですか…？
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310040")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★マルディサント★★:ばぁか、脚本・主演はアタシだよ！<br>オニーサンは木の役とかやってろ
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A110_310041")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、いや、あの…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310042")

	PlayAction(Actor003,"to  Std_Angry")
	change_face(Actor003,"Anger")

	--★★マルディサント★★:アァ！？木の役が不満か！役に大小なんざねえ！<br>精一杯やれ！全力でやれ！死ぬ気でやれ！木を！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A110_310043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:じゃなくて、金コートは<br>さすがに恥ずかしいかなと…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310044")


	--★★ギネヴィア★★:まあねえ、ノワールが題材なの<br>モロバレだもんねえ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310045")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Normal")

	--★★エレイン★★:確かに…明らかな戦意高揚目的に取られても<br>意図とは異なりますしね…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310046")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,30,0.5)
wait_time(0.5)
PlayActionDirect(Actor006,"to  Std_Talk")
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★ディナタン★★:じゃあじゃあマァルが主役なんだし<br>黒い騎士様のお話にしたら？
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01A110_310048")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
	change_face(Actor003,"Shy")

	--★★マルディサント★★:か、簡単に言うなァ…！もお書き始めてたんだぜ<br>直すのも結構タイヘンでさぁ──
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A110_310049")

-- ▼直接出力
lookat_delay_weight(Actor007, {1.0, 0.1, 0.5, 0.3} , 0.6)
keep_ik_lookat(Actor007, Actor003, "J_Head")
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★モルガン★★:マルディサントの黒く輝く晴れ姿<br>先生…見たいなあ
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310051")

	PlayAction(Actor003,"to  Std_Joy")
	open_cutin(1,2)
	on_cutin(1,Actor003,"Smile")

	--★★マルディサント★★:やぁってやるぜ！！
	Talk(Actor003,"CHRNAME_MALADISANT","speech","N","MA_01A110_310053")

	close_cutin()
	PlayAction(Actor007,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight_reset(Actor007 , 0.6)
-- ▲直接出力

	--★★モルガン★★:でねでね、お姫様役が難しい２択なの！<br>もと王妃様か、お姫様か…
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310055")

	open_cutin(2,1)
	on_cutin(1,Actor002,"Surprise")
	on_cutin(2,Actor005,"Surprise")

	--★★ギネヴィア／エレイン★★:えっ！？！？
	Talk(Actor009,"CHRNAME_GUINEVERE_ELAINE","speech","N","MA_01A110_310057")

	close_cutin()
	PlayAction(Actor002,"to  Std_Talk")

	--★★ギネヴィア★★:聞いてないんだけど！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310058")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Surp")
	change_face(Actor005,"Sad")

	--★★エレイン★★:やったことないんですけど…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310059")

-- ▼直接出力
CloseTalkWindow()
manager.CloseupUpExclusiveCamera(Actor006)
PlayActionDirect(Actor006,"to Wlk")
turn_chara(Actor006,-40,0.5)
wait_time(0.5)
PlayActionDirect(Actor006,"to Std_Loop")
play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★ディナタン★★:どちらにしても盛り上がりそうですね…！<br>どちらにしても適役そうだけど、兄さん？
	Talk(Actor006,"CHRNAME_DINATAN","speech","L","MA_01A110_310060")

	open_select_window_tag(Actor001,"Normal","MA_01A110_310062","MA_01A110_310063")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight(Actor001, {1.0, 0.08, 0.5, 0.3} , 0.6)
keep_ik_lookat(Actor001, Actor002, "J_Head")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ギネヴィアかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310065")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:ええ～！？えええ～！？<br>でっきるっかなああああああ？？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_310066")

	change_face(Actor003,"Sad")

	--★★マルディサント★★:まんざらでもなさそうじゃん
	Talk(Actor003,"CHRNAME_MALADISANT","speech","L","MA_01A110_310067")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
lookat_delay_weight(Actor001, {1.0, 0.08, 0.5, 0.3} , 0.6)
keep_ik_lookat(Actor001, Actor005, "J_Head")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:エレインに頼みたいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_310069")

	PlayAction(Actor005,"to  Std_Sad02")
	change_face(Actor005,"Shy")

	--★★エレイン★★:え、わ、私に………！？<br>でも、私――…
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310070")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★アーサー★★:賛成だ。学園祭復活を直談判してくれた<br>その意志は舞台上からも必ず伝わるだろうな
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310071")

	change_face(Actor005,"Surprise")

	--★★エレイン★★:…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310072")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Anger")

	--★★エレイン★★:………やらせて、いただきます…！
	Talk(Actor005,"CHRNAME_ELAINE","speech","L","MA_01A110_310073")

	goto Block2end

::Block2end::
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor001)
Hide(Actor006)
Hide(Actor003)
Hide(Actor005)
Hide(Actor002)
Hide(Actor008)
Camera004 = setup_small_camera_resetting(Actor004,CharaPos003,CameraPos003)
wait_time(0.2)
keep_ik_lookat(Actor004,Actor007,"J_Head")
lookat_weight(Actor004,1.0,0.08,0.5,0)
keep_ik_lookat(Actor007,Actor004,"J_Head")
lookat_weight(Actor007,1.0,0.1,0.5,0)
setup_small_camera_start()
wait_time(0.5)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:平和ボケしてると思うか？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310075")

	change_face(Actor007,"Normal")

	--★★モルガン★★:あなたが決めたんでしょう？
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310076")


	--★★モルガン★★:笑えるときに笑って欲しいのは私も同じ<br>学園の生徒たちにも、貴方にも
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310077")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★アーサー★★:…義姉さん
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01A110_310078")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor007 , 0.6)
-- ▲直接出力
	change_face(Actor007,"Smile")

	--★★モルガン★★:ずぅっと<br>楽しい学園のままで、いたいわね
	Talk(Actor007,"CHRNAME_MORGAN","speech","L","MA_01A110_310079")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110141)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor008")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110141_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
