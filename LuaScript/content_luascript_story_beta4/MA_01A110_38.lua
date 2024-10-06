-- このluaスクリプトは、MA_01A110_38.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_07","110011_07_h")
Include("content_adv_advsmall_110011_07","Template110011_07_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_07_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_07_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_07_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_07_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110011_07_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110011_07,CameraPos110011_07_001)
	InitializeTemplateRandomCamera110011_07()
	InitializeTemplate110011_07()
-- ▼直接出力
set_enable_auto_lookat_all(false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
lookat_weight(Actor002, {1.0, 0, 0.5, 0})
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
change_face(Actor003,"Sad")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115020)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "落胆")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★マルディサント★★:演技以前の問題だな
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380002")

	change_face(Actor003,"Sad")

	--★★エレイン★★:ガタガタガタ…！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380004")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ガタガタ震えている…！<br>こんな調子で大丈夫なのかしら…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_380005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:すすすすす、すみません…！<br>本番、たくさんの人に見られると思うと…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A110_380008","MA_01A110_380009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor003,true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:本当にやれる？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_380011")

-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
lookat_delay_weight(Actor003, {1.0, 0.08, 0.4, 0.6} , 1.0)
 --PlayPartVoice("エレイン", "悲しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:すみません<br>先輩に迷惑をかけてしまって…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380012")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★エレイン★★:でも、ローマとの戦いも控えているのに<br>こんなことくらいで躓いてられませんから…！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380013")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:一緒に頑張ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_380015")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:木がいつも見守っててくれるさ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380016")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★エレイン★★:ず、ず、ずっと見守られているのも<br>それは、それで、ちょっと…！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380017")

	goto Block1end

::Block1end::
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
-- ▼直接出力
change_face(Actor001,"Normal")
 --PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:…アンタさァ<br>自分がスキじゃねえんだろ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380019")

-- ▼直接出力
lookat_delay_weight_reset(Actor003 , 0.6)
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エレイン★★:へっ
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380020")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "悩む")
-- ▲直接出力

	--★★マルディサント★★:だから舞台で自分を見せることに<br>申し訳なさすら感じてる、違ぇかな？
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "苦しみ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:うっ…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380022")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:だけど台本に書いてある台詞なら<br>別人になれるから平気かも…そう思ってたんだろ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380023")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:………そう、かも…しれません
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380024")


	--★★マルディサント★★:書いてある文字を読むだけならガキでもできる<br>誰もが簡単に芝居できんじゃねえか勘違いしてる
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380025")

	play_head_motion(Actor005, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マルディサント★★:けどよ、ンな甘いもんじゃねえんだよ演技は<br>職人ワザなんだよ、本来はな
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380026")

	PlayAction(Actor003,"to  Std_Sad01")
-- ▼直接出力
 --PlayPartVoice("エレイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Pain")

	--★★エレイン★★:ご、ご、ごめんなさい………
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor005,"J_Head",1.0)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ディナタン★★:マァル～～～ッ！ツメ過ぎ！！泣いちゃう！！<br>初めてなんだからしょうがないよ…！！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01A110_380028")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("エレイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★エレイン★★:い、いいえ…<br>言い出しっぺがこんなでは…！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380029")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:「しょうがないデキのモン」<br>そんなんでイイのかよ？
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エレイン★★:え…？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380031")


	--★★マルディサント★★:なんで学園祭なんておめでてーこと<br>アタシらでやんだっけ？
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380032")

	change_face(Actor003,"Sad")

	--★★エレイン★★:………それは
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380033")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "激怒")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マルディサント★★:いっちょ前に別人になろうとしてんじゃねえ！<br>なれねえよ、プロじゃねえんだからよ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380034")

-- ▼直接出力
 --PlayPartVoice("エレイン", "肯定")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★エレイン★★:別人には、なれない…
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380035")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "怒り")
-- ▲直接出力

	--★★マルディサント★★:仮にアンタが役の立場になったらどーするか！<br>アンタが決めろ、アンタを舞台上に乗せろ！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380036")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マルディサント★★:演技のセオリーとしてはイマイチだが<br>「私なんか」って思って逃げ腰になるよかイイ！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380038")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "気合い")
-- ▲直接出力

	--★★マルディサント★★:エレイン！<br>アンタはアンタの美しさを知れ！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380039")

-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力

	--★★エレイン★★:私の、美しさ…？
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380040")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight_reset(Actor004 , 0.6)
 --PlayPartVoice("ディナタン", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ディナタン★★:マァルが暑苦しい…<br>エレインが混乱してるよ…
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01A110_380041")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:フッ、マルディサントの言い分には<br>一理あるわね…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A110_380042")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "悩む")
-- ▲直接出力

	--★★ディナタン★★:ギネヴィアさんは<br>なんか感化されている…！
	Talk(Actor004,"CHRNAME_DINATAN","speech","L","MA_01A110_380043")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "挨拶")
-- ▲直接出力

	--★★マルディサント★★:木！いるか！木！<br>出てこい！木を継ぐ者よ！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380044")

-- ▼直接出力
set_enable_auto_lookat(Actor005,true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、俺か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_380045")

-- ▼直接出力
set_enable_auto_lookat(Actor005,false)
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★マルディサント★★:オニーサン、今日はアタシの代役だ<br>騎士役…ちょっとやってみろよ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380046")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("エレイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Shy")

	--★★エレイン★★:えっっっ！！
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380047")

-- ▼直接出力
 --PlayPartVoice("マルディサント", "肯定")
-- ▲直接出力

	--★★マルディサント★★:エレイン、さっき言った「美しさ」っつーのはさ<br>ルックスとかそういう話じゃないんだぜ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380048")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)

	--★★マルディサント★★:人間の中の、本当の想いってヤツだ<br>それは誰しも持っていて、誰しも美しいんだよ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マルディサント★★:そーゆー恥ずかしくて、デリケェトな部分を…<br>内側をさらしてこそ…人の心ってのは動くんだよ
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380050")

-- ▼直接出力
 --PlayPartVoice("エレイン", "納得")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★エレイン★★:…私の、内側
	Talk(Actor003,"CHRNAME_ELAINE","speech","L","MA_01A110_380051")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("マルディサント", "気合い")
-- ▲直接出力
	change_face(Actor005,"Anger")

	--★★マルディサント★★:やるぞ！覚悟決めろよ！死ぬなら舞台上で死ね！<br>いや、客の心臓握りつぶす気で行け！！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380053")


	--★★マルディサント★★:稽古は反復！特にトーシロはな！！<br>ほら、オニーサン！台本持ちな！
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わ、わかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A110_380055")


	--★★マルディサント★★:いくぞ！まずは出会いのシーンから――
	Talk(Actor005,"CHRNAME_MALADISANT","speech","L","MA_01A110_380057")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115020)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_07)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
