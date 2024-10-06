-- このluaスクリプトは、MA_01B109_34.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",47.5,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_008_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera005 = SetTemplate("Actor005",205,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera006 = SetTemplate("Actor006",240,CharaPosDuelCommonFormation01_007,"content_motion3d_advarea_common_adv_templatecontroller","Npc_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_007)
	Camera007 = SetTemplate("Actor007",50,CharaPosDuelCommonFormation01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_008)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor002)
set_pos(Actor005, {-3.661, 0, -15.575, 205})
set_pos(Actor006, {-5.65, 0, -10.15, 240})
set_pos(Actor007, {-3.98, 0, -23.42, 50})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000012)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401012","001","401012001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:これが国葬の準備か<br>みんな忙しそうだな…ん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340002")

	PlayAction(Actor004,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ボールス★★:カーライル城の件は聞いた<br>ついていってやれずすまなかった
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340004")


	--★★ボールス★★:聖杯探索としては徒労だったようだが<br>戦果としてはじゅうぶんだろう
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:俺にもなにか手伝えることはあるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340006")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ボールス★★:葬られんよう自愛することだな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340008")


	--★★ノワール★★:「休め」ってことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340009")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力

	--★★ボールス★★:継承者に倒れられて<br>困るのは俺たちだからな？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340011")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:この…花火を打ち上げての国葬って<br>ログレスではよくやってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340012")

	change_face(Actor004,"Sad")

	--★★ボールス★★:…ユーサー王が逝去されたとき以来だ<br>前回は８年ほど前になる
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_340014","MA_01B109_340015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:詳しく知らないんだが<br>ユーサー王は何が原因で亡くなったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340017")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:アーサー王が生まれて間もなく<br>この城がバルバロイに襲われてな
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340018")

	change_face(Actor004,"Sad")

	--★★ボールス★★:その際にユーサー王妃イグレーヌ様が亡くなった
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340019")

	change_face(Actor004,"Sad")

	--★★ボールス★★:ユーサー王は仇をとるため<br>城を襲ったバルバロイの討伐に乗り出し
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340020")

	PlayAction(Actor004,"to  Std_Sad01")
	change_face(Actor004,"Sad")

	--★★ボールス★★:８年前、とうとう仇を討つに至ったが<br>代わりに致命傷を負ったのだそうだ
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340021")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ボールスは<br>８年前の国葬に出席したのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340024")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:いや。俺はそのときはまだ<br>ログレスに来ていなかった
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうか<br>ボールスも今回が初めてか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340026")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ボールス★★:この国葬は花火を打ち上げるだけでなく
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340028")


	--★★ボールス★★:火種に故人の手向けの品を投げ込み<br>ともに天へと送るという儀式があるらしい
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340029")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ボールス★★:もし送りたい品があるなら<br>一緒に送るといい
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340030")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor003,Camera003,EntryDataDuelCommonFormation01_03,CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_103)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ヴォールス", "肯定3")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ボールス★★:パーシヴァル<br>手向けの品を持ってきたのか？
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340032")

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("パーシヴァル", "肯定3")
-- ▲直接出力

	--★★パーシヴァル★★:ボクだって見送りたい人くらいいる
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B109_340034")


	--★★パーシヴァル★★:このあいだの戦いの参加者のなかに<br>ボクと仲良くしてくれた…
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B109_340035")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Surprise")

	--★★パーシヴァル★★:ボ、ボクが面倒を見てやっていた<br>庶民がいてね！
	Talk(Actor003,"CHRNAME_PERCIVAL","speech","L","MA_01B109_340036")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ボールス★★:俺も今<br>手向けの品を預けに行こうと思っていた
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340037")


	--★★ボールス★★:パーシヴァル、ついてこい<br>案内してやる
	Talk(Actor004,"CHRNAME_BORS","speech","L","MA_01B109_340038")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
Hide(Actor004)
Hide(Actor003)
Appear(Actor002)
setup_small_camera_start()
wait_time(CHARA_IN_WAIT)
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力

	--★★ディナタン★★:兄さんも来てたんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340040")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ディナタン<br>手向けの品物を持ってきたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:うん、ブライアンさんにね<br>…なんだと思う？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01B109_340043","MA_01B109_340044","MA_01B109_340045")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ブライアンが好きだったものか…<br>わかった、酒だろう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340047")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:はずれー<br>それも考えたけどね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340048")

	change_face(Actor002,"Normal")

	--★★ディナタン★★:「酒なんて量が飲めりゃ<br>銘柄なんて問わねえよ」って口癖で
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340049")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:とくにどんなお酒が好きなのか<br>私にはわからなかったから
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340050")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ブライアンがいつも持っていたもの…<br>わかった、斧だろう！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340052")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ディナタン", "否定")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:あの大きな斧を<br>私が持てるわけないでしょ？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340053")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:真面目に考えてよ、もう
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340054")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ブライアンが大事にしていて<br>俺たちにも関係あるもの、か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340056")

	change_face(Actor001,"Normal")

	--★★ノワール★★:『不格好なコート』の徽章…とか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340057")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:正解！<br>さすがもと団長ね！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340059")

	goto Block2end

::Block2end::
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私たちとブライアンさんの繋がりの証に<br>『不格好なコート』の徽章はどうかなって
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340061")


	--★★ディナタン★★:ブライアンさんが付けていたものは<br>形見としてとっておいて
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340062")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:私が団にいたときに付けていたものを<br>手向けの品にしようと思うの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340063")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん、いいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340064")


	--★★ノワール★★:ブライアンの徽章を<br>ディナタンが持っていてくれるのなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340065")


	--★★ノワール★★:俺も自分のものを<br>ブライアンへの手向けにするよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340066")

	PlayAction(Actor001,"to  Std_Worry")

	--★★ノワール★★:それと、あとは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340067")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ディナタン★★:まだあるの？<br>ほかにも見送りたい人、いるんだ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340068")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？あ、ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340069")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:戦いでなくなった<br>たくさんのひとたちにも何か送れたらって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340070")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ディナタン★★:そっか。そうだね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340072")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私もなにかもう少し探してこよっと
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01B109_340073")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")

	--★★ノワール★★:（それと…父さんには……）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01B109_340075")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000012)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101026","001","101026001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401012","001","401012001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
