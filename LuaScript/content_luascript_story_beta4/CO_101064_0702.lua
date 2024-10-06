-- このluaスクリプトは、CO_101064_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110101_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110101_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110101_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110101)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	template1()
end

function Play()
	StartPlay()

	change_face(Actor002,"Smile")

	--★★リアム★★:失礼<br>少々意外だったのです
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020002")


	--★★ノワール★★:意外…？<br>なにがだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020003")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★リアム★★:もともと貴方がここへ来ていたのは<br>ハーブの栽培方法を学ぶためでしょう
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020004")


	--★★リアム★★:確かに交換条件として<br>私は大聖堂の仕事の手伝いをお願いしましたが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020005")


	--★★リアム★★:先ほど貴方はハーブの栽培よりも先に<br>なにか手伝えることはないか、と私に尋ねた
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020006")

	open_select_window_tag(Actor001,"Normal","CO_101064_07020008","CO_101064_07020009")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それは確かに…<br>言われるまで気づかなかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020011")

	change_face(Actor001,"Normal")

	--★★ノワール★★:でももう、ここの手伝いするのが<br>習慣みたいになっちゃったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020012")

	change_face(Actor001,"Smile")

	--★★ノワール★★:街のみんなの喜ぶ顔を見られるのは<br>俺も嬉しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020013")

	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ハーブのことは抜きにして<br>手伝えることがあるならいつでも言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020014")

	change_face(Actor002,"Surprise")

	--★★リアム★★:人のよい方だとは思っていましたが<br>ここまでとは…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020015")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★リアム★★:騎士にしておくのが<br>もったいないほどの博愛精神ですね
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020016")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、それは…手伝ったあとに<br>ハーブのことを聞くつもりだったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020018")

	change_face(Actor002,"Smile")

	--★★リアム★★:ふふっ。そうですか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020019")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:だ、だから！<br>なにか俺に手伝えることはないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020020")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★リアム★★:ノワールさん
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ん、なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020023")

	PlayAction(Actor002,"to  Std_Talk")

	--★★リアム★★:貴方は誰になにを言われずとも<br>周囲のことを考えて動ける人です
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020024")


	--★★リアム★★:その在りようは称賛に値します
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020025")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020027")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（ここまで言われると…<br>照れるを通り越して落ち着かないな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101064_07020028")

	PlayAction(Actor004,"to Greet_one")

	--★★モルドレッド★★:よう、クソ司祭
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","CO_101064_07020030")

	change_face(Actor002,"Surprise")

	--★★リアム★★:おや、モルドレッド卿<br>なにかご用ですか？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020031")


	--★★モルドレッド★★:なんかよ。おめえの知り合いだってヤツが<br>さがしてたぞ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","CO_101064_07020032")


	--★★リアム★★:私の知り合い…？
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020033")

	PlayAction(Actor004,"to  Std_Talk")

	--★★モルドレッド★★:ケンカ慣れしてそうなヤツだったな<br>昔のツレか？お礼参りってセンもあるな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","CO_101064_07020034")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Normal")

	--★★リアム★★:そのあたりの話はむやみに口にしないよう<br>言っておいたはずですが。モルドレッド卿
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020035")

	change_face(Actor004,"Smile")

	--★★モルドレッド★★:おーおー怖い怖い
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","CO_101064_07020037")

	PlayAction(Actor004,"to Greet_one")

	--★★モルドレッド★★:それじゃ、確かに伝えたぜ<br>せいぜい気を付けるこったな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","CO_101064_07020038")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★リアム★★:やれやれ、彼は変わりませんね…<br>もう少し落ち着いてほしいものですが
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なにがあったんだ、リアムさん？<br>助太刀が必要なら言ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020041")

	change_face(Actor002,"Normal")

	--★★リアム★★:必要ありませんよ<br>昔ならいざ知らず、今更そんな輩が…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020042")

	change_face(Actor002,"Surprise")

	--★★リアム★★:まさか…
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020044")


	--★★ノワール★★:リアムさん？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020046")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Smile")

	--★★リアム★★:いえ、なんでもありません
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020048")

	change_face(Actor003,"Surprise")

	--★★クラリス★★:リアム様～！大変です～<br>ハーブ園にムッ、ムシが出ましたぁ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101064_07020050")

	change_face(Actor003,"Sad")

	--★★クラリス★★:やっつけてください～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","CO_101064_07020051")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Surprise")

	--★★リアム★★:おやおや、それは大変ですね<br>ノワール卿、手伝ってもらえますか
	Talk(Actor002,"CHRNAME_LIAM","speech","L","CO_101064_07020052")

	change_face(Actor001,"Sad")

	--★★ノワール★★:うっ！？<br>む、ムシか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_07020053")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_リアム_ランクアップ7_3")
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
	load_area_scene_preload(110101)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
