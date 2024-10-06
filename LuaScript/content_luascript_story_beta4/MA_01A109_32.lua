-- このluaスクリプトは、MA_01A109_32.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110021_01","110021_01_h")
Include("content_adv_advsmall_110021_01","Template110021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",77.58,CharaPos110021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110021_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_008)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110021_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_007)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110021_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110021_01,CameraPos110021_01_009)
	InitializeTemplateRandomCamera110021_01()
	InitializeTemplate110021_01()
-- ▼直接出力
set_common_look_at(Actor001,Actor002,1)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor002,Actor001,1)
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor003,Actor001,1)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor006)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
Hide(Actor007)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115024)
	Actor001 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101028","002","101028002","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101039","001","101039001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★モルガン★★:戦い詰めでしょう<br>安静にしていてと言ったはずよ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:戦い詰めなのは騎士たちも同じだし…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320003")

	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モルガン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★モルガン★★:言い訳しない！！
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
Appear(Actor004)
-- ▲直接出力
-- ▼直接出力
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
Appear(Actor006)
-- ▲直接出力
-- ▼直接出力
	pActor004 = get_pos(Actor004)
	pActor005 = get_pos(Actor005)
	pActor006 = get_pos(Actor006)
-- ▲直接出力
-- ▼直接出力
	local tbloffset4 = {pActor004[1] + 2.0 ,pActor004[2] + 0 ,pActor004[3] + 0}
	local tbloffset5 = {pActor005[1] + 2.0 ,pActor005[2] + 0 ,pActor005[3] + 0}
	local tbloffset6 = {pActor006[1] + 2.0 ,pActor006[2] + 0 ,pActor006[3] + 0}
-- ▲直接出力
-- ▼直接出力
	set_pos(Actor004,tbloffset4) --初期位置設定
	set_pos(Actor005,tbloffset5) --初期位置設定
	set_pos(Actor006,tbloffset6) --初期位置設定
-- ▲直接出力
-- ▼直接出力
turn_lookat_position(Actor004,pActor004[1],pActor004[2],pActor004[3],0) --向きを行先に合わせる
turn_lookat_position(Actor005,pActor005[1],pActor005[2],pActor005[3],0) --向きを行先に合わせる
turn_lookat_position(Actor006,pActor006[1],pActor006[2],pActor006[3],0) --向きを行先に合わせる
-- ▲直接出力
-- ▼直接出力
	PlayActionDirect(Actor004,"to Wlk")
	PlayActionDirect(Actor005,"to Wlk")
	PlayActionDirect(Actor006,"to Wlk")
-- ▲直接出力
-- ▼直接出力
	slidemove(Actor004,pActor004[1],pActor004[2],pActor004[3],2.0 ) --ポジションに移動
	slidemove(Actor005,pActor005[1],pActor005[2],pActor005[3],2.0 ) --ポジションに移動
	slidemove(Actor006,pActor006[1],pActor006[2],pActor006[3],2.0 ) --ポジションに移動
	wait_time(1.5)
	setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
	PlayActionDirect(Actor004,"to Std_Loop")--待機に戻す
	PlayActionDirect(Actor005,"to Std_Loop")--待機に戻す
	PlayActionDirect(Actor006,"to Std_Loop")--待機に戻す
	wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor006,false)
set_common_look_at(Actor006,Actor002,0.6)
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ノワール★★:なにがあったんですか…？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_320006")

-- ▼直接出力
	setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★モルガン★★:あ、ノワールくん聞いてよ～<br>アーサーがね、私の言うことを聞いてくれないの
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320007")


	--★★モルガン★★:安静にしてて欲しいのに<br>聖杯探索班の援護に出て行っちゃうし…
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor004,"Normal","MA_01A109_320010","MA_01A109_320011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:そのへんで許してやってください…
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_320013")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:アーサーが来なければ<br>魔女を取り逃がしてしまっていたよ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_320014")

-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★モルガン★★:みんなアーサーの味方をするの？<br>ガラハッド、貴方はどう？
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320015")

	PlayAction(Actor006,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ガラハッド★★:が、ガラハッドか…！？<br>ガラハッドは、ど、どちらとも…
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01A109_320016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ノワール★★:もっとやっちゃってください
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_320018")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("アーサー", "驚き")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:ノ、ノワール！？<br>俺は一生懸命みんなのためにだなあ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320019")

-- ▼直接出力
 --PlayPartVoice("モルガン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★モルガン★★:ノワールくんもああ言ってるじゃない<br>しっかり反省しなさい！
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320020")

	goto Block1end

::Block1end::
-- ▼直接出力
set_common_look_at(Actor001,Actor002,0.6)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★モルガン★★:アーサー…貴方は王様、この国の要よ<br>進んで傷つけられに行くことはないわ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320022")


	--★★モルガン★★:誰よりも面倒事を引き受けていること<br>貴方のカラダを診ている私にわからないとでも？
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320023")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("モルガン", "苦しみ")
-- ▲直接出力

	--★★モルガン★★:8月に魔女姉妹全員の刃を一身に受けて<br>臓腑の一部は使い物にもならない
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:かすり傷だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320026")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力

	--★★モルガン★★:マーリンのサポートなしでは<br>満足に戦えるかどうか…
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320027")

-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:…ランスと約束したんだよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320028")

	change_face(Actor001,"Normal")

	--★★モルガン★★:なあに、オトコ同士の約束？
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320029")

-- ▼直接出力
Appear(Actor007)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★フレン★★:（…アーサー王、もし…もし仮に<br>ルーシャスくんの言うことが本当だとしたら…）
	Talk(Actor007,"CHRNAME_FREN","mind","L","MA_01A109_320031")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:ノワールを焚きつけたのは俺たちだ
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_320032")

	change_face(Actor007,"Anger")

	--★★フレン★★:（ローマの屍を踏みつけて<br>ログレスの支配を目論んだユーサーの子）
	Talk(Actor007,"CHRNAME_FREN","mind","L","MA_01A109_320034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:学園は継承者を探し出し<br>重荷を背負わせた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320036")

	change_face(Actor008,"Sad")

	--★★フレン_テキストのみ★★:（そして次は、継承者を踏みつけて<br>ログレスの制圧を…ううん、だとしても）
	Talk(Actor008,"CHRNAME_FREN","mind","L","MA_01A109_320038")


	--★★フレン_テキストのみ★★:（バルバロイは倒さなければならない敵…<br>わかってる、ルーシャスくんは間違ってる）
	Talk(Actor008,"CHRNAME_FREN","mind","L","MA_01A109_320039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:ノワールは歩み続け<br>今や己の武器を選び出した
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320040")


	--★★フレン_テキストのみ★★:（でも…継承者だけじゃない、生徒たちも<br>死と隣り合わせ、聖遺物化の恐怖だって…あって）
	Talk(Actor008,"CHRNAME_FREN","mind","L","MA_01A109_320042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:なら俺たちは終わりまで<br>その選択に報いる義務がある
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320043")


	--★★フレン_テキストのみ★★:（どう報いられたとしても<br>戻って来ないものがあるんじゃないの）
	Talk(Actor008,"CHRNAME_FREN","mind","L","MA_01A109_320044")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルガン", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★モルガン★★:…王様としては失格よ
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320045")


	--★★フレン_テキストのみ★★:（ルーシャスくん、君はそんななかでどうやって<br>かつてのローマを取り戻そうとしてるの？）
	Talk(Actor008,"CHRNAME_FREN","mind","L","MA_01A109_320047")


	--★★フレン_テキストのみ★★:（間違ってるよ、きっとそれは）
	Talk(Actor008,"CHRNAME_FREN","mind","L","MA_01A109_320048")

-- ▼直接出力
setup_small_camera_start(Camera007)
-- ▲直接出力
	change_face(Actor007,"Sad")

	--★★フレン★★:（間違ってる君に、誰がついていくの？）
	Talk(Actor007,"CHRNAME_FREN","mind","L","MA_01A109_320049")

-- ▼直接出力
 --去る表現がわかりづらいので少し移動を入れる
CloseTalkWindow()
pActor007 = get_pos(Actor007)
local tbloffset7 = {pActor007[1] + 0.0 ,pActor007[2] + 0 ,pActor007[3] + 3.0}
PlayActionDirect(Actor007,"to Run")
turn_lookat_position(Actor007,tbloffset7[1],tbloffset7[2],tbloffset7[3],0.3) --向きを行先に合わせる
slidemove(Actor007,tbloffset7[1],tbloffset7[2],tbloffset7[3],1.3) --ポジションに移動
wait_time(0.5)

-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor007)
set_enable_auto_lookat_all(true)　--自動化再開
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("モルガン", "苦しみ")
-- ▲直接出力

	--★★モルガン★★:さびしい想いをする家族がいるのも<br>忘れないで
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320051")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:面目ない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320052")

-- ▼直接出力
 --PlayPartVoice("モルガン", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★モルガン★★:お義姉さんに謝りなさい！！<br>気苦労絶えないマーリンにも！！
	Talk(Actor001,"CHRNAME_MORGAN","speech","L","MA_01A109_320053")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★アーサー★★:ウッ！ゴメンナサッ！！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","MA_01A109_320055")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("マーリン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★マーリン★★:あらあら<br>義姉様には素直なんですねえ
	Talk(Actor003,"CHRNAME_MERLIN","speech","L","MA_01A109_320056")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
wait_time(0.3)
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor003)
Hide(Actor001)
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
Camera004 =setup_small_camera_resetting(Actor004,CharaPos110021_01_002,CameraPos002)
Camera005 =setup_small_camera_resetting(Actor005,CharaPos110021_01_006,CameraPos006)
set_enable_auto_lookat_all(false)
turn_lookat( Actor004, Actor005, 0)
turn_lookat( Actor005, Actor004, 0)
turn_lookat( Actor006, Actor004, 0)
lookat_weight_default( Actor004)
wait_time(1.0)
set_enable_auto_lookat(Actor006,true)
lookat_weight_default( Actor005)
lookat_weight_default( Actor006)
-- ▲直接出力
-- ▼直接出力
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ノワール★★:聖杯探索は順調か？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_320058")

	change_face(Actor006,"Smile")

	--★★ガラハッド★★:…ログレスの者たちは優秀だな<br>学ぶことばかりだ
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01A109_320059")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ランスロット★★:周囲を優れていると感じられる素直な感性…<br>それが大切だ、多くを学ぶにはな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_320060")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Angry")
	open_cutin(1,1)
	on_cutin(1,Actor006,"Anger")

	--★★ガラハッド★★:だがガラハッドは負けないぞ！<br>円卓の騎士！
	Talk(Actor006,"CHRNAME_GALAHAD","speech","N","MA_01A109_320062")

	close_cutin()
-- ▼直接出力
turn_lookat( Actor006, Actor004, 0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力

	--★★ガラハッド★★:誇り高き騎士には見合った戦果が必要だ<br>それが欲しい。必ず聖杯を見つけ出してみせる
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01A109_320063")

	change_face(Actor006,"Normal")

	--★★ガラハッド★★:万人の大望を叶えるという聖杯と<br>継承者による世界救済…
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01A109_320064")

	change_face(Actor006,"Anger")

	--★★ガラハッド★★:その道を拓く者こそガラハッドだ！<br>我ら銀卓の矜持に懸けて！
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01A109_320065")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ランスロット", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ランスロット★★:ずっとこの調子だ<br>使命感がから回らなければいいが
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_320066")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ノワール★★:あんたみたいだな
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_320067")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ランスロット★★:なに？
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_320068")

-- ▼直接出力
 --PlayPartVoice("ガラハッド", "笑い")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★ガラハッド★★:ふふ。そうだ<br>ランスロットを見習っているんだ
	Talk(Actor006,"CHRNAME_GALAHAD","speech","L","MA_01A109_320069")

-- ▼直接出力
 --PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ランスロット★★:ノワールみたいだな
	Talk(Actor005,"CHRNAME_LANCELOT","speech","L","MA_01A109_320071")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ノワール★★:ええ？
	Talk(Actor004,"CHRNAME_NOIR","speech","L","MA_01A109_320073")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115024)
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101028","002","101028002","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101039","001","101039001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
