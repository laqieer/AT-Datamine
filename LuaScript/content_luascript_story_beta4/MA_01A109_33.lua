-- このluaスクリプトは、MA_01A109_33.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110081_01","110081_01_h")
Include("content_adv_advsmall_110081_01","Template110081_01_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-195,CharaPos110081_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110081_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110081_01,CameraPos110081_01_002)
	InitializeTemplateRandomCamera110081_01()
	InitializeTemplate110081_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
-- ▼直接出力
Hide(Actor002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110081)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_TextOnly()
	template1()
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ギネヴィア★★:………あんまり
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330002")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★テロップ★★:「なにも識らない継承者<br>哀れで不憫なそのキラーズ」
	Talk(Actor003,"telop","narration","N","MA_01A109_330003")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:おいしく、なかったな
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330005")

-- ▼直接出力
CloseTalkWindow()
-- 黒背景の表示
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★テロップ★★:「盟約果たせば永劫の別れ<br>愛しき人の選択は二度と帰らぬ旅への切符」
	Talk(Actor003,"telop","narration","N","MA_01A109_330006")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力

	--★★ギネヴィア★★:別れ…<br>なんでわたしが、どうして…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330007")


	--★★テロップ★★:「いくら見栄を張り続けようと」<br>「どれだけ眩く輝こうと」
	Talk(Actor003,"telop","narration","N","MA_01A109_330008")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "否定")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:それの<br>なにがいけないのよ…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330010")


	--★★テロップ★★:「かわいそうな、あなた」
	Talk(Actor003,"telop","narration","N","MA_01A109_330011")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330012")


	--★★テロップ★★:「眩しくて、妬ましかったよ」
	Talk(Actor003,"telop","narration","N","MA_01A109_330013")

-- ▼直接出力
 --白黒終了フェードアウト
CloseTalkWindow() --疑似バトルなら
setup_small_camera_start(Camera001)
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:お構いなく。皇太子殿下──
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330015")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
EntryWalk(Actor002,Camera002,EntryData110081_01_02,CameraAssetBundleName110081_01,CameraPos110081_01_102)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★フレン★★:伺っても。王妃殿下
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330017")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,CharaPos110081_01_004[4],0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.5)
SkipOffsetCamera(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:…もう王妃は降りたけれど<br>えと、あなたは──
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330018")

	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:どうして貴方は<br>ルーシャスくんを選ばなかったんです
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:なんの…ハナシ？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330020")

-- ▼直接出力
 --PlayPartVoice("フレン", "怒り")
-- ▲直接出力

	--★★フレン★★:目をかけられていたはずです<br>ことあるごとに
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330021")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ギネヴィア★★:お戯れでしょ、あんなの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330022")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:本気じゃないことくらい<br>はた目からもわかるはずよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:キャメリアードを救ったときも<br>カレドニアと戦う前も──
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:ルーシャスくんはいつも貴方に力を貸していた<br>ローマ本国に誘われたこともあったはずです
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フレン★★:ルーシャスくんについていけば<br>何不自由ない世界が広がっていたはずです
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330026")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:こんなところで議論は避けたいわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フレン", "激怒")
-- ▲直接出力

	--★★フレン★★:こたえてッ！！
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330028")

-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
lookat_weight_reset(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:………こんなことになるんじゃないかと<br>感じていたからよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330030")

	PlayAction(Actor002,"to  Std_Angry")

	--★★フレン★★:この国がそうしたんじゃないのッ！？
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, true)
-- ▲直接出力
-- ▼直接出力
lookat_weight_default(Actor001)
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat( Actor001, Actor002, "J_Head", 1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:…！あなた、知ってるの…！？<br>なにを…どこまで──…！？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330033")

	change_face(Actor002,"Sad")

	--★★フレン★★:片一方の言い分で物事を判断してしまうほど<br>浅はかではないけれど──
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330034")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★フレン★★:なにが本当なのか誰もわからない以上<br>私が選ばなきゃならない…！
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("フレン", "怒り")
-- ▲直接出力

	--★★フレン★★:貴方は…座を降りたとはいえ<br>この国の元王妃として、彼を殺すんですか
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330036")


	--★★フレン★★:彼を追い込んだこの国で…<br>使命感だけに駆られて…
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330037")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:宣言、したはずです
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フレン★★:「欲するは勝利のみ」ですか
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:もう誰も望まないはずです。故郷を奪われるのも<br>大切な人が消えてしまうのも
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330041")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:…ご高説、痛み入ります
	Talk(Actor002,"CHRNAME_FREN","speech","L","MA_01A109_330042")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
se_play("SE_ADV_CO_101030_0303_Foot_1_Person")
wait_time(CHARA_IN_WAIT+1.2)
Hide(Actor002)
setup_small_camera_end()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:………間違ってないよね、パパ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A109_330044")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110081)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
MobsNo = 0
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110081_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
