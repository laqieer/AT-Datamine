-- このluaスクリプトは、MA_01105_17.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114031_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_005)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114031_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_008)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_2DOnly("101020","001","101020001")
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガウェイン★★:やる気ねーなら<br>帰ってもいいんだぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170002")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★ラグネル★★:ガウェイン…<br>ダメ教師みたいな言いかたしないでよ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170003")

	change_face(Actor003,"Anger")

	--★★ガウェイン★★:はっきりさせようぜ。ノワール
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")

	--★★マーリン★★:ここはログレス領の穀倉地帯<br>アストラット郷
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01105_170006")


	--★★マーリン★★:バルバロイの目撃例が少なく<br>ご覧のように緑が豊かということもあり
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01105_170007")


	--★★マーリン★★:リフレッシュのために訪れる<br>騎士たちも多いと聞きます
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01105_170008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★マーリン★★:このあたりで休息をとりましょう<br>積もる話もあるでしょうから、ごゆっくり
	Talk(Actor005,"CHRNAME_MERLIN","speech","L","MA_01105_170009")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor005)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor006,"to  Std_Talk")

	--★★ラグネル★★:…ほら～、急ぎの任務なのに<br>マーリン様が観光案内みたいになっちゃったよ？
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170011")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:誰も抜いたことのねえ剣を抜いた。認めるぜ<br>なにか特別な力を持ってるってのは
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170013")


	--★★ガウェイン★★:だけど<br>これからはお前の古巣と戦わなきゃなんねえ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170014")

	PlayAction(Actor006,"to  Std_Talk")
	change_face(Actor006,"Normal")

	--★★ラグネル★★:カレドニアに雇われたけど<br>裏切られたんでしょ？
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170016")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:バルバロイなんて化け物に<br>喰われそうになってね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_170017")

	change_face(Actor003,"Anger")

	--★★ガウェイン★★:けど、前の戦場では<br>ランスロットに剣を向けた
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170018")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
	change_face(Actor006,"Sad")

	--★★ラグネル★★:ガウェイン<br>そんな蒸し返さなくったって…
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:ほっておきましょーよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_170020")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★ギネマウア★★:休憩時間にまで働く勤労精神<br>見習いたいものですね
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_170021")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ガウェイン★★:ランスロットとノワール<br>どういう関係なんだよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01105_170025","MA_01105_170026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
	change_face(Actor001,"Anger")

	--★★ノワール★★:父さんの仇だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170028")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:そうなんだってな<br>だからさがして戦場さまよってたんだろ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170029")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:同じ学園で、同じ円卓について<br>それでお前はいいのかよ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170030")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:憧れなんだ<br>小さいころからの
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170032")

	change_face(Actor006,"Normal")

	--★★ラグネル★★:前に言ってたね<br>幼馴染だって
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170033")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:だが今は<br>なぜだか仇ってわけだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170034")

	goto Block1end

::Block1end::
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:憧れてた人が親父さんの仇って<br>どんな気分なんだよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170036")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:最悪だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170037")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:だろうな<br>本当のトコもわかんねーままで
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170038")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:妹も…きっとそう思っている<br>なにもわからないままで、もがいている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170039")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:だから俺が『本当』を聞き出さなきゃならない<br>それだけが家族を救える唯一の手段だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170041")


	--★★ギネヴィア★★:…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_170043")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Serious")

	--★★ノワール★★:俺は戦う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170044")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:バルバロイは<br>俺たちの居場所を奪った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170045")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:もう誰にも奪わせない<br>『本当』も、家族も、居場所も
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170046")

	change_face(Actor003,"Smile")

	--★★ガウェイン★★:…欲張りなヤツ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170048")

	open_select_window_tag(Actor001,"Normal","MA_01105_170050","MA_01105_170051","MA_01105_170052")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の命の恩人の故郷も<br>取り戻さなきゃならない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170054")

	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:………それって、わたしのこと？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_170055")

	play_head_motion(Actor007, "Nod", 0.3, 1.0, false)
	change_face(Actor007,"Smile")

	--★★ギネマウア★★:居場所を奪われた者同士<br>支え合わねばなりませんね
	Talk(Actor007,"NPCNAME_0070","speech","L","MA_01105_170057")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガウェインの助けにもなりたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170059")

	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:なんでそこで俺が出てくんだよ…！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170060")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:クラスで孤立していた俺を救ってくれたのは<br>ガウェインだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170061")

	PlayAction(Actor003,"to  Std_No")
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:み、見るに堪えなかっただけだよ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170062")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★ラグネル★★:いいんじゃない？<br>そのぐらいの理由でさ
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170063")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:これ以上<br>家族に心配をかけないためにも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170065")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:どーしたって心配かけちまうだろうけどな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170066")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
	change_face(Actor006,"Smile")

	--★★ラグネル★★:早く帰ってあげなきゃだね
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170067")

	goto Block2end

::Block2end::
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は助けられてばかりだ<br>気が逸ってばかりで…ディナタンのことを言えない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170069")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:だから俺は俺自身の手で進む先を選びたい<br>俺自身の足で歩きたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170071")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
-- ▲直接出力

	--★★ノワール★★:助けてくれた人を<br>守れるような武器が欲しいんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_170072")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Surprise")

	--★★ラグネル★★:………やる気
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170073")

	change_face(Actor003,"Normal")

	--★★ガウェイン★★:まんまんじゃねーの
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170074")

	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:イイぜ。イイ憧れだ<br>お前見込みあるぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170075")

	change_face(Actor006,"Sad")

	--★★ラグネル★★:え、ガウェイン、ナニサマ？
	Talk(Actor006,"CHRNAME_RAGNAR","speech","L","MA_01105_170076")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ガウェイン★★:もったいねーよ<br>憧れのままにしとくのは
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170077")


	--★★マーリン02★★:積もる話は済みましたか？
	Talk(Actor008,"CHRNAME_MERLIN","speech","L","MA_01105_170079")

	change_face(Actor003,"Laugh")

	--★★ガウェイン★★:行こうぜ、ノワール
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170081")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:話せばキリがなくなりそうだ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01105_170083")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor007")
	InitializeCharacter_2DOnly_Preload("101020","001","101020001")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor007,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
